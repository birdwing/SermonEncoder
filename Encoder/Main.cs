using FireEncoder;
using FireEncoder.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using System.Xml;
using WinSCP;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Encoder
{
    public partial class Sermons : Form
    {
        public WinSCP.Protocol Proto { get; set; }
        public string Host { get; set; }
        public string Port { get; set; }
        public string Dir { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Sermons()
        {
            InitializeComponent();
        }

        private void FTPSettingsBtn_Click(object sender, EventArgs e)
        {
            //Call FTP Settings Dialog
            using (var form = new FTPSettings())
            {
                var result = form.ShowDialog();
            }
        }

        private void FFmpegSettingsBtn_Click(object sender, EventArgs e)
        {
            //Call Encoder Settings Dialog
            using (var form = new EncoderSettings())
            {
                var result = form.ShowDialog();
            }
        }

        private void AddSermonBtn_Click(object sender, EventArgs e)
        {
            //Call Add Sermon Dialog
            using (var form = new AddSermon(QueueLst))
            {
                var result = form.ShowDialog();
                //If the dialog is closed with the "Ok" button and has no errors.
                if (result == DialogResult.OK)
                {
                    //Add Sermon to List
                    var Sermon = new ListViewItem();
                    Sermon.Text = form.Title;
                    Sermon.SubItems.Add(form.Speaker);
                    Sermon.SubItems.Add(form.Scripture);
                    Sermon.SubItems.Add(form.Date.ToString());
                    Sermon.SubItems.Add(form.File);
                    Sermon.SubItems.Add(form.Output);
                    Sermon.SubItems.Add(form.Status);
                    Sermon.Group = QueueLst.Groups["Waiting"];
                    QueueLst.Items.Add(Sermon);
                }
            }
        }

        private void RemoveSermonBtn_Click(object sender, EventArgs e)
        {
            //Get the selected list item
            var Selected = QueueLst.SelectedIndices;

            foreach (int sermon in Selected)
            {
                if(QueueLst.Items[sermon].Group == QueueLst.Groups["Uploading"] || QueueLst.Items[sermon].Group == QueueLst.Groups["Processing"])
                {
                    MessageBox.Show("You cannot remove a Sermon that is currently Processing or Uploading.", "Can Not Remove", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } else
                {
                    QueueLst.Items[sermon].Remove();
                }
            }
        }

        private void ShutdownChk_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Shutdown = ShutdownChk.Checked;
            Properties.Settings.Default.Save();
        }

        private void ProcessBtn_Click(object sender, EventArgs e)
        {
            //Set all the FTP variables from settings
            FTPSettings();
            //Begin Sermon Processing
            ProcessSermons();
        }

        private void FTPSettings()
        {
            var dir = "";
            var host = "";

            //Set all the FTP variables from settings
            switch (Properties.Settings.Default.FTPProtocol)
            {
                case "FTP":
                    this.Proto = Protocol.Ftp;
                    dir = Properties.Settings.Default.FTPDir;
                    host = Properties.Settings.Default.FTPHost;
                    break;
                case "Amazon S3":
                    this.Proto = Protocol.S3;
                    dir = Properties.Settings.Default.FTPDir;
                    host = "s3.amazonaws.com";
                    break;
                default:
                    this.Proto = Protocol.Ftp;
                    dir = Properties.Settings.Default.FTPDir;
                    host = Properties.Settings.Default.FTPHost;
                    break;
            }
            this.Port = Properties.Settings.Default.FTPPort;
            this.Username = Properties.Settings.Default.FTPUsername;
            this.Password = Properties.Settings.Default.FTPPassword;

            // replace all backslashes with forward slash is dir and host
            dir = dir.Replace(@"\", @"/");
            host = host.Replace(@"\", @"/");
            // Make sure dir isn't just a backslash "/"
            if (dir == @"/")
            {
                dir = "";
            }
            //Strip leading slash from dir if exists
            if (dir.Length > 1 && dir.Substring(0, 1) == @"/")
            {
                dir = dir.Substring(1);
            }
            //Strip trailing slash from dir and host if exists
            if (dir.Length > 1 && dir.Substring((dir.Length - 1), 1) == @"/")
            {
                dir = dir.Remove(dir.Length - 1);
            }
            if (host.Length > 1 && host.Substring((host.Length - 1), 1) == @"/")
            {
                host = host.Remove(host.Length - 1);
            }

            //Strip ftp://, http://, and https:// from beginning of HOST if exists
            if (host.Length > 6 && host.Substring(0, 6) == @"ftp://")
            {
                host = host.Substring(6);
            }
            if (host.Length > 7 && host.Substring(0, 7) == @"http://")
            {
                host = host.Substring(7);
            }
            if (host.Length > 8 && host.Substring(0, 8) == @"https://")
            {
                host = host.Substring(8);
            }

            //add leading slash to dir if exists
            if (!string.IsNullOrEmpty(dir))
            {
                dir = $@"/{dir}";
            }

            //if S3 combine "host" and "dir" to get the bucket and folders.
            if(this.Proto == Protocol.S3)
            {
                dir = "/" + Properties.Settings.Default.FTPHost + dir;
            }

            this.Host = host;
            this.Dir = dir;
        }

        private void ProcessSermons()
        {
            //Get list of Sermons to be processed, in "Processing" group
            var Items = QueueLst.Groups["Waiting"].Items;

            //Loop through sermons and begin to encode them.
            foreach (ListViewItem Sermon in Items)
            {
                ProcessSermon(Sermon);
            }
        }

        private void ProcessSermon(ListViewItem Sermon)
        {
            //Determine the filename based on the sermon date
            DateTime SermonDate = DateTime.Parse(Sermon.SubItems[3].Text);
            string FileName = SermonDate.ToString("MM-dd-yyyy");

            //Create the XML file for this sermon
            //If successful begin Encoding Process
            if (CreateSermonXML(Sermon))
            {
                SermonEncoder Encoder = new SermonEncoder();
                XInputFile InputFile = new XInputFile()
                {
                    InputName = Sermon.SubItems[4].Text
                };
                XOutputFile AudioFile = new XOutputFile()
                {
                    OutputName = $@"{Sermon.SubItems[5].Text}\{FileName}.mp3"
                };
                XOutputFile VideoFile = new XOutputFile()
                {
                    OutputName = $@"{Sermon.SubItems[5].Text}\{FileName}.mp4"
                };
                Encoder.WorkingDirectory = Properties.Settings.Default.FFmpegDir;
                Encoder.FFmpegPath = Properties.Settings.Default.FFmpegPath;
                Encoder.ProgressChanged += ProgressChangedEvent;
                Encoder.EncodeCompleted += EncodeCompletedEvent;
                Encoder.Sermon = Sermon;
                Encoder.AddCommand(InputFile);
                Encoder.AddCommand(
                    new XCustomCommand()
                    {
                        Command = $@"-acodec libmp3lame -ab 96k -ar 48000 -joint_stereo 1 -metadata title=""{Sermon.Text}"" -metadata artist=""{Sermon.SubItems[1].Text}"" -metadata album=""Gateway Worship Center"" -metadata genre=""Christian Sermon"""
                    }
                );
                Encoder.AddCommand(AudioFile);
                Encoder.AddCommand(
                    new XCustomCommand()
                    {
                        Command = $@"-vcodec libx264 -f mp4 -vb 256k -r 29.97 -profile:v main -level:v 4.0 -preset slow -acodec aac -strict -2 -ab 160k -ar 48000 -vf scale=710:-2"
                    }
                );
                Encoder.AddCommand(VideoFile);
                Encoder.AddCommand(new XOverwrite());

                Encoder.StartEncodeAsync();
            }
        }

        private void ProgressChangedEvent(object sender, EncodeProgressChangedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                //Update the percentage for this specific sermon
                SermonEncoder Encoder = (SermonEncoder)sender;
                var Sermon = Encoder.Sermon;

                //If sermon is in "Waiting" move to Processing
                if(Sermon.Group == QueueLst.Groups["Waiting"])
                {
                    Sermon.Group = QueueLst.Groups["Processing"];
                }

                Sermon.SubItems[6].Text = $"Processing - {e.ProgressPercentage.ToString()}%";
            }));
        }

        private void EncodeCompletedEvent(object sender, EncodeCompletedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                //When finished Move the Sermon to "Uploading" and begin uploading.
                SermonEncoder Encoder = (SermonEncoder)sender;
                var Sermon = Encoder.Sermon;

                //Check for errors
                if (e.Success)
                {
                    Sermon.Group = QueueLst.Groups["Uploading"];
                    UploadSermon(Sermon);
                } else
                {
                    Sermon.SubItems[6].Text = $"Processing - Error - {e.ConsoleOuptut}";
                    Sermon.BackColor = Color.Salmon;
                }

                Encoder.Dispose();
            }));
        }

        private bool CreateSermonXML(ListViewItem Sermon)
        {
            DateTime SermonDate = DateTime.Parse(Sermon.SubItems[3].Text);
            string FileName = SermonDate.ToString("MM-dd-yyyy");

            XmlWriterSettings settings = new XmlWriterSettings()
            {
                Indent = true,
                IndentChars = "    ",
                NewLineOnAttributes = true,
                NewLineChars = Environment.NewLine
            };

            try
            {
                using (XmlWriter writer = XmlWriter.Create($@"{Sermon.SubItems[5].Text}\{FileName}.xml", settings))
                {
                    writer.WriteStartElement("sermon");
                    writer.WriteElementString("title", Sermon.Text);
                    writer.WriteElementString("speaker", Sermon.SubItems[1].Text);
                    writer.WriteElementString("scripture", Sermon.SubItems[2].Text);
                    writer.WriteElementString("date", $@"{SermonDate.ToString("yyyy-MM-dd HH:mm")}:00");
                    writer.WriteEndElement();
                    writer.Flush();
                }

                return true;
            } catch(Exception ex)
            {
                Sermon.SubItems[6].Text = $"Create XML - Error - {ex.Message}";
                Sermon.BackColor = Color.Salmon;
                return false;
            }
        }

        private void UploadSermon(ListViewItem Sermon)
        {
            //Determine the folder name based on the sermon date
            DateTime SermonDate = DateTime.Parse(Sermon.SubItems[3].Text);
            string FolderName = SermonDate.ToString("MM-dd-yyyy");

            Sermon.SubItems[6].Text = $"Uploading XML - 0%";

            try
            {
                //Setup WinSCP Session Options
                SessionOptions sessionOptions = new SessionOptions
                {
                    Protocol = this.Proto,
                    HostName = this.Host,
                    PortNumber = int.Parse(this.Port),
                    UserName = this.Username,
                    Password = this.Password
                };
                
                using (Session session = new Session())
                {
                    //Connect
                    session.Open(sessionOptions);
                    //Check if upload directory exists on FTP server
                    if (session.FileExists($@"{this.Dir}/{FolderName}"))
                    {
                        //Delete directory
                        if(!session.RemoveFiles($@"{this.Dir}/{FolderName}").IsSuccess)
                        {
                            throw new Exception("Could not remove upload directory on FTP server.");
                        }
                    }

                    //Create uploading directory on FTP server
                    session.CreateDirectory($@"{this.Dir}/{FolderName}");
                    session.Dispose();
                }
                UploadSermonXML(Sermon);
            } catch (Exception e)
            {
                Sermon.SubItems[6].Text = $"Upload - Error Creating Directory - {e.ToString()}";
                Sermon.BackColor = Color.Salmon;
            }
        }

        private void SessionFileTransferProgress(object sender, FileTransferProgressEventArgs e, BackgroundWorker uploader)
        {
            uploader.ReportProgress(int.Parse((e.FileProgress * 100).ToString()));
        }

        private void progressChanged(object sender, ProgressChangedEventArgs e, ListViewItem Sermon)
        {
            Invoke(new Action(() =>
            {
                //Get List Items status without percentage
                var status = Sermon.SubItems[6].Text;
                int index = status.LastIndexOf("-");
                if (index > 0)
                {
                    status = status.Substring(0, index);
                }
                Sermon.SubItems[6].Text = $"{status}- {e.ProgressPercentage.ToString()}%";
            }));
        }

        private void UploadSermonXML(ListViewItem Sermon)
        {
            //Determine the folder name based on the sermon date
            DateTime SermonDate = DateTime.Parse(Sermon.SubItems[3].Text);
            string FolderName = SermonDate.ToString("MM-dd-yyyy");

            string localDir = $@"{Sermon.SubItems[5].Text}\{FolderName}.xml";
            string remoteDir = $@"{this.Dir}/{FolderName}/";

            //Upload XML file
            Sermon.SubItems[6].Text = "Uploading XML - 0%";

            try
            {
                //Setup WinSCP Session Options
                SessionOptions sessionOptions = new SessionOptions
                {
                    Protocol = this.Proto,
                    HostName = this.Host,
                    PortNumber = int.Parse(this.Port),
                    UserName = this.Username,
                    Password = this.Password
                };

                //Set transfer options
                TransferOptions transferOptions = new TransferOptions();
                transferOptions.ResumeSupport.State = TransferResumeSupportState.On;

                //create background worker
                BackgroundWorker uploader = new BackgroundWorker();
                uploader.WorkerReportsProgress = true;
                uploader.DoWork += delegate (object sender, DoWorkEventArgs e) {
                    using (Session session = new Session())
                    {
                        //Set Session Progress tracker
                        session.FileTransferProgress += delegate (object s, FileTransferProgressEventArgs ev) { SessionFileTransferProgress(s, ev, uploader); };

                        //Connect
                        session.Open(sessionOptions);

                        //Upload File
                        TransferOperationResult transferResult = session.PutFiles(localDir, remoteDir, false, transferOptions);

                        //Throw on any error
                        transferResult.Check();

                        //Update when transfer complete
                        if (transferResult.IsSuccess)
                        {
                            Invoke(new Action(() =>
                            {
                                Sermon.SubItems[6].Text = "Uploading XML - 100%";
                            }));

                            e.Result = session;
                        }
                    }

                };

                uploader.ProgressChanged += delegate (object sender, ProgressChangedEventArgs e) { progressChanged(sender, e, Sermon); };

                //Create handler for when upload completes
                uploader.RunWorkerCompleted += delegate (object sender, RunWorkerCompletedEventArgs e)
                {
                    if (e.Error == null)
                    {
                        Session session = (Session)e.Result;
                        session.Dispose();
                        UploadSermonAudio(Sermon);
                    }
                    else
                    {
                        throw (new Exception(e.Error.Message));
                    }
                };

                //Begin Upload
                uploader.RunWorkerAsync();
            }
            catch (Exception e)
            {
                Sermon.SubItems[6].Text = $"Upload XML - Error - {e.ToString()}";
                Sermon.BackColor = Color.Salmon;
            }
        }

        private void UploadSermonAudio(ListViewItem Sermon)
        {
            //Determine the folder name based on the sermon date
            DateTime SermonDate = DateTime.Parse(Sermon.SubItems[3].Text);
            string FolderName = SermonDate.ToString("MM-dd-yyyy");

            string localDir = $@"{Sermon.SubItems[5].Text}\{FolderName}.mp3";
            string remoteDir = $@"{this.Dir}/{FolderName}/";

            //Upload Audio file
            Sermon.SubItems[6].Text = "Uploading Audio - 0%";

            try
            {
                //Setup WinSCP Session Options
                SessionOptions sessionOptions = new SessionOptions
                {
                    Protocol = this.Proto,
                    HostName = this.Host,
                    PortNumber = int.Parse(this.Port),
                    UserName = this.Username,
                    Password = this.Password
                };

                //Set transfer options
                TransferOptions transferOptions = new TransferOptions();
                transferOptions.ResumeSupport.State = TransferResumeSupportState.On;

                //create background worker
                BackgroundWorker uploader = new BackgroundWorker();
                uploader.WorkerReportsProgress = true;
                uploader.DoWork += delegate (object sender, DoWorkEventArgs e) {
                    using (Session session = new Session())
                    {
                        //Set Session Progress tracker
                        session.FileTransferProgress += delegate (object s, FileTransferProgressEventArgs ev) { SessionFileTransferProgress(s, ev, uploader); };

                        //Connect
                        session.Open(sessionOptions);

                        //Upload File
                        TransferOperationResult transferResult = session.PutFiles(localDir, remoteDir, false, transferOptions);

                        //Throw on any error
                        transferResult.Check();

                        //Update when transfer complete
                        if (transferResult.IsSuccess)
                        {
                            Invoke(new Action(() =>
                            {
                                Sermon.SubItems[6].Text = "Uploading Audio - 100%";
                            }));

                            e.Result = session;
                        }
                    }

                };

                uploader.ProgressChanged += delegate (object sender, ProgressChangedEventArgs e) { progressChanged(sender, e, Sermon); };

                //Create handler for when upload completes
                uploader.RunWorkerCompleted += delegate (object sender, RunWorkerCompletedEventArgs e)
                {
                    if (e.Error == null)
                    {
                        Session session = (Session)e.Result;
                        session.Dispose();
                        UploadSermonVideo(Sermon);
                    }
                    else
                    {
                        throw (new Exception(e.Error.Message));
                    }
                };

                //Begin Upload
                uploader.RunWorkerAsync();
            }
            catch (Exception e)
            {
                Sermon.SubItems[6].Text = $"Upload Audio - Error - {e.ToString()}";
                Sermon.BackColor = Color.Salmon;
            }
        }

        private void UploadSermonVideo(ListViewItem Sermon)
        {
            //Determine the folder name based on the sermon date
            DateTime SermonDate = DateTime.Parse(Sermon.SubItems[3].Text);
            string FolderName = SermonDate.ToString("MM-dd-yyyy");

            string localDir = $@"{Sermon.SubItems[5].Text}\{FolderName}.mp4";
            string remoteDir = $@"{this.Dir}/{FolderName}/";

            //Upload Video file
            Sermon.SubItems[6].Text = "Uploading Video - 0%";

            try
            {
                //Setup WinSCP Session Options
                SessionOptions sessionOptions = new SessionOptions
                {
                    Protocol = this.Proto,
                    HostName = this.Host,
                    PortNumber = int.Parse(this.Port),
                    UserName = this.Username,
                    Password = this.Password
                };
            
                //Set transfer options
                TransferOptions transferOptions = new TransferOptions();
                transferOptions.ResumeSupport.State = TransferResumeSupportState.On;
            
                //create background worker
                BackgroundWorker uploader = new BackgroundWorker();
                uploader.WorkerReportsProgress = true;
                uploader.DoWork += delegate (object sender, DoWorkEventArgs e) {
                    using (Session session = new Session())
                    {
                        //Set Session Progress tracker
                        session.FileTransferProgress += delegate (object s, FileTransferProgressEventArgs ev) { SessionFileTransferProgress(s, ev, uploader); };

                        //Connect
                        session.Open(sessionOptions);

                        //Upload File
                        TransferOperationResult transferResult = session.PutFiles(localDir, remoteDir, false, transferOptions);

                        //Throw on any error
                        transferResult.Check();

                        //Update when transfer complete
                        if(transferResult.IsSuccess)
                        {
                            Invoke(new Action(() =>
                            {
                                Sermon.SubItems[6].Text = "Uploading Video - 100%";
                            }));

                            e.Result = session;
                        }
                    }

                };

                uploader.ProgressChanged += delegate (object sender, ProgressChangedEventArgs e) { progressChanged(sender, e, Sermon); };

                //Create handler for when upload completes
                uploader.RunWorkerCompleted += delegate (object sender, RunWorkerCompletedEventArgs e)
                {
                    if(e.Error == null)
                    {
                        Session session = (Session)e.Result;
                        session.Dispose();
                        //Set Sermon Complete notification
                        Invoke(new Action(() =>
                        {
                            Sermon.SubItems[6].Text = $"Uploaded Successfully - Completed";
                            Sermon.Group = QueueLst.Groups["Completed"];
                            Sermon.BackColor = Color.LightGreen;
                        }));

                        //Check if everything is done processing and uploading.
                        CheckIfDone();
                    } else
                    {
                        Sermon.SubItems[6].Text = $"Upload Video - Error - {e.Error.Message}";
                        Sermon.BackColor = Color.Salmon;
                    }
                };

                //Begin Upload
                uploader.RunWorkerAsync();
            }
            catch (Exception e)
            {
                Sermon.SubItems[6].Text = $"Upload Video - Error - {e.ToString()}";
                Sermon.BackColor = Color.Salmon;
            }
        }

        private void CheckIfDone()
        {
            Invoke(new Action(() =>
            {
                int ProcessingCount = QueueLst.Groups["Processing"].Items.Count;
                int UploadingCount = QueueLst.Groups["Uploading"].Items.Count;

                if(Properties.Settings.Default.Shutdown && (ProcessingCount + UploadingCount) == 0)
                {
                    var psi = new ProcessStartInfo("shutdown", "/s /t 0");
                    psi.CreateNoWindow = true;
                    psi.UseShellExecute = false;
                    Process.Start(psi);
                }
            }));
        }
    }
}
