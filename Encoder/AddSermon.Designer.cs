using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encoder
{
    partial class AddSermon
    {
        private ListView Sermons { get; set; }

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(ListView Sermons)
        {
            this.Sermons = Sermons;
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSermon));
            this.AddSermonPanel = new System.Windows.Forms.Panel();
            this.AddSermonDateLbl = new System.Windows.Forms.Label();
            this.AddSermonScriptureLbl = new System.Windows.Forms.Label();
            this.AddSermonSpeakerLbl = new System.Windows.Forms.Label();
            this.AddSermonTitleLbl = new System.Windows.Forms.Label();
            this.AddSermonDate = new System.Windows.Forms.DateTimePicker();
            this.AddSermonScriptureTxt = new System.Windows.Forms.TextBox();
            this.AddSermonSpeakerTxt = new System.Windows.Forms.TextBox();
            this.AddSermonTitleTxt = new System.Windows.Forms.TextBox();
            this.AddSermonFileBtn = new System.Windows.Forms.Button();
            this.AddSermonFileTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddSermonCancelBtn = new System.Windows.Forms.Button();
            this.AddSermonOkBtn = new System.Windows.Forms.Button();
            this.AddSermonOutputBtn = new System.Windows.Forms.Button();
            this.AddSermonOutputTxt = new System.Windows.Forms.TextBox();
            this.SermonErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.SermonStatusProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.AddSermonPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SermonErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SermonStatusProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // AddSermonPanel
            // 
            this.AddSermonPanel.Controls.Add(this.AddSermonDateLbl);
            this.AddSermonPanel.Controls.Add(this.AddSermonScriptureLbl);
            this.AddSermonPanel.Controls.Add(this.AddSermonSpeakerLbl);
            this.AddSermonPanel.Controls.Add(this.AddSermonTitleLbl);
            this.AddSermonPanel.Controls.Add(this.AddSermonDate);
            this.AddSermonPanel.Controls.Add(this.AddSermonScriptureTxt);
            this.AddSermonPanel.Controls.Add(this.AddSermonSpeakerTxt);
            this.AddSermonPanel.Controls.Add(this.AddSermonTitleTxt);
            this.AddSermonPanel.Location = new System.Drawing.Point(12, 5);
            this.AddSermonPanel.Name = "AddSermonPanel";
            this.AddSermonPanel.Size = new System.Drawing.Size(501, 117);
            this.AddSermonPanel.TabIndex = 0;
            // 
            // AddSermonDateLbl
            // 
            this.AddSermonDateLbl.AutoSize = true;
            this.AddSermonDateLbl.Location = new System.Drawing.Point(4, 93);
            this.AddSermonDateLbl.Name = "AddSermonDateLbl";
            this.AddSermonDateLbl.Size = new System.Drawing.Size(30, 13);
            this.AddSermonDateLbl.TabIndex = 7;
            this.AddSermonDateLbl.Text = "Date";
            // 
            // AddSermonScriptureLbl
            // 
            this.AddSermonScriptureLbl.AutoSize = true;
            this.AddSermonScriptureLbl.Location = new System.Drawing.Point(4, 67);
            this.AddSermonScriptureLbl.Name = "AddSermonScriptureLbl";
            this.AddSermonScriptureLbl.Size = new System.Drawing.Size(49, 13);
            this.AddSermonScriptureLbl.TabIndex = 6;
            this.AddSermonScriptureLbl.Text = "Scripture";
            // 
            // AddSermonSpeakerLbl
            // 
            this.AddSermonSpeakerLbl.AutoSize = true;
            this.AddSermonSpeakerLbl.Location = new System.Drawing.Point(4, 41);
            this.AddSermonSpeakerLbl.Name = "AddSermonSpeakerLbl";
            this.AddSermonSpeakerLbl.Size = new System.Drawing.Size(47, 13);
            this.AddSermonSpeakerLbl.TabIndex = 5;
            this.AddSermonSpeakerLbl.Text = "Speaker";
            // 
            // AddSermonTitleLbl
            // 
            this.AddSermonTitleLbl.AutoSize = true;
            this.AddSermonTitleLbl.Location = new System.Drawing.Point(4, 14);
            this.AddSermonTitleLbl.Name = "AddSermonTitleLbl";
            this.AddSermonTitleLbl.Size = new System.Drawing.Size(27, 13);
            this.AddSermonTitleLbl.TabIndex = 4;
            this.AddSermonTitleLbl.Text = "Title";
            // 
            // AddSermonDate
            // 
            this.AddSermonDate.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.AddSermonDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AddSermonDate.Location = new System.Drawing.Point(63, 86);
            this.AddSermonDate.Name = "AddSermonDate";
            this.AddSermonDate.Size = new System.Drawing.Size(411, 20);
            this.AddSermonDate.TabIndex = 3;
            this.AddSermonDate.Validating += new System.ComponentModel.CancelEventHandler(this.SermonDate_Validated);
            // 
            // AddSermonScriptureTxt
            // 
            this.AddSermonScriptureTxt.Location = new System.Drawing.Point(63, 60);
            this.AddSermonScriptureTxt.Name = "AddSermonScriptureTxt";
            this.AddSermonScriptureTxt.Size = new System.Drawing.Size(411, 20);
            this.AddSermonScriptureTxt.TabIndex = 2;
            this.AddSermonScriptureTxt.Validating += new System.ComponentModel.CancelEventHandler(this.SermonScripture_ValidatedAsync);
            // 
            // AddSermonSpeakerTxt
            // 
            this.AddSermonSpeakerTxt.Location = new System.Drawing.Point(63, 34);
            this.AddSermonSpeakerTxt.Name = "AddSermonSpeakerTxt";
            this.AddSermonSpeakerTxt.Size = new System.Drawing.Size(411, 20);
            this.AddSermonSpeakerTxt.TabIndex = 1;
            this.AddSermonSpeakerTxt.Validating += new System.ComponentModel.CancelEventHandler(this.SermonSpeaker_Validated);
            // 
            // AddSermonTitleTxt
            // 
            this.AddSermonTitleTxt.Location = new System.Drawing.Point(63, 8);
            this.AddSermonTitleTxt.Name = "AddSermonTitleTxt";
            this.AddSermonTitleTxt.Size = new System.Drawing.Size(411, 20);
            this.AddSermonTitleTxt.TabIndex = 0;
            this.AddSermonTitleTxt.Validating += new System.ComponentModel.CancelEventHandler(this.SermonTitle_Validated);
            // 
            // AddSermonFileBtn
            // 
            this.AddSermonFileBtn.Location = new System.Drawing.Point(12, 130);
            this.AddSermonFileBtn.Name = "AddSermonFileBtn";
            this.AddSermonFileBtn.Size = new System.Drawing.Size(102, 23);
            this.AddSermonFileBtn.TabIndex = 8;
            this.AddSermonFileBtn.Text = "Select Video File";
            this.AddSermonFileBtn.UseVisualStyleBackColor = true;
            this.AddSermonFileBtn.Click += new System.EventHandler(this.AddSermonFileBtn_Click);
            // 
            // AddSermonFileTxt
            // 
            this.AddSermonFileTxt.Enabled = false;
            this.AddSermonFileTxt.Location = new System.Drawing.Point(120, 132);
            this.AddSermonFileTxt.Name = "AddSermonFileTxt";
            this.AddSermonFileTxt.Size = new System.Drawing.Size(366, 20);
            this.AddSermonFileTxt.TabIndex = 9;
            this.AddSermonFileTxt.Validating += new System.ComponentModel.CancelEventHandler(this.SermonFile_Validated);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddSermonCancelBtn);
            this.panel1.Controls.Add(this.AddSermonOkBtn);
            this.panel1.Location = new System.Drawing.Point(324, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 29);
            this.panel1.TabIndex = 10;
            // 
            // AddSermonCancelBtn
            // 
            this.AddSermonCancelBtn.Location = new System.Drawing.Point(84, 3);
            this.AddSermonCancelBtn.Name = "AddSermonCancelBtn";
            this.AddSermonCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.AddSermonCancelBtn.TabIndex = 1;
            this.AddSermonCancelBtn.Text = "Cancel";
            this.AddSermonCancelBtn.UseVisualStyleBackColor = true;
            this.AddSermonCancelBtn.Click += new System.EventHandler(this.AddSermonCancelBtn_Click);
            // 
            // AddSermonOkBtn
            // 
            this.AddSermonOkBtn.Location = new System.Drawing.Point(3, 3);
            this.AddSermonOkBtn.Name = "AddSermonOkBtn";
            this.AddSermonOkBtn.Size = new System.Drawing.Size(75, 23);
            this.AddSermonOkBtn.TabIndex = 0;
            this.AddSermonOkBtn.Text = "Ok";
            this.AddSermonOkBtn.UseVisualStyleBackColor = true;
            this.AddSermonOkBtn.Click += new System.EventHandler(this.AddSermonOkBtn_Click);
            // 
            // AddSermonOutputBtn
            // 
            this.AddSermonOutputBtn.Location = new System.Drawing.Point(12, 160);
            this.AddSermonOutputBtn.Name = "AddSermonOutputBtn";
            this.AddSermonOutputBtn.Size = new System.Drawing.Size(102, 23);
            this.AddSermonOutputBtn.TabIndex = 11;
            this.AddSermonOutputBtn.Text = "Output Directory";
            this.AddSermonOutputBtn.UseVisualStyleBackColor = true;
            this.AddSermonOutputBtn.Click += new System.EventHandler(this.AddSermonOutputBtn_Click);
            // 
            // AddSermonOutputTxt
            // 
            this.AddSermonOutputTxt.Enabled = false;
            this.AddSermonOutputTxt.Location = new System.Drawing.Point(120, 162);
            this.AddSermonOutputTxt.Name = "AddSermonOutputTxt";
            this.AddSermonOutputTxt.Size = new System.Drawing.Size(366, 20);
            this.AddSermonOutputTxt.TabIndex = 12;
            this.AddSermonOutputTxt.Validating += new System.ComponentModel.CancelEventHandler(this.SermonOutput_Validated);
            // 
            // SermonErrorProvider
            // 
            this.SermonErrorProvider.BlinkRate = 1000;
            this.SermonErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.SermonErrorProvider.ContainerControl = this;
            // 
            // SermonStatusProvider
            // 
            this.SermonStatusProvider.BlinkRate = 1000;
            this.SermonStatusProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.SermonStatusProvider.ContainerControl = this;
            this.SermonStatusProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("SermonStatusProvider.Icon")));
            // 
            // AddSermon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 233);
            this.Controls.Add(this.AddSermonOutputTxt);
            this.Controls.Add(this.AddSermonOutputBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddSermonFileTxt);
            this.Controls.Add(this.AddSermonFileBtn);
            this.Controls.Add(this.AddSermonPanel);
            this.Name = "AddSermon";
            this.Text = "AddSermon";
            this.AddSermonPanel.ResumeLayout(false);
            this.AddSermonPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SermonErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SermonStatusProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void SermonTitle_Validated(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(this.AddSermonTitleTxt.Text))
            {
                SermonErrorProvider.SetError(this.AddSermonTitleTxt, "Title is required.");
            } else
            {
                SermonErrorProvider.SetError(this.AddSermonTitleTxt, string.Empty);
            }
        }

        private async void SermonScripture_ValidatedAsync(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(this.AddSermonScriptureTxt.Text))
            {
                SermonErrorProvider.SetError(this.AddSermonScriptureTxt, "Scripture is required.");
            } else
            {
                //Add Question status icon Error, to prevent form from being saved while validating scripture
                SermonErrorProvider.SetError(this.AddSermonScriptureTxt, string.Empty);
                SermonStatusProvider.SetError(this.AddSermonScriptureTxt, "Validating...");

                //Call Get Bible API to verify the scripture is valid.
                if (await VerifyScripture(this.AddSermonScriptureTxt.Text))
                {
                    SermonStatusProvider.SetError(this.AddSermonScriptureTxt, string.Empty);
                } else
                {
                    SermonStatusProvider.SetError(this.AddSermonScriptureTxt, string.Empty);
                    SermonErrorProvider.SetError(this.AddSermonScriptureTxt, "Scripture is not Valid.");
                }

            }
        }

        static async Task<bool> VerifyScripture(string Scripture)
        {
            var values = new Dictionary<string, string>()
            {
                { "scripture", Scripture }
            };
            var content = new FormUrlEncodedContent(values);
            string path = $@"https://bible-api.com/{Scripture}";
            //var response = await webClient.PostAsync(path, content);
            var response = await webClient.GetAsync(path);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void SermonDate_Validated(object sender, System.EventArgs e)
        {
            //Determine the sermon file name based on the sermon date
            string FileName = DateTime.Parse(AddSermonDate.Text).ToString("MM-dd-yyyy");

            //Loop through each sermon to see if dates match if so throw error
            bool hasError = false;
            foreach (ListViewItem Sermon in this.Sermons.Items)
            {
                string SermonDate = DateTime.Parse(Sermon.SubItems[3].Text).ToString("MM-dd-yyyy");
                if (SermonDate == FileName)
                {
                    hasError = true;
                    break;
                }
            }

            if (hasError)
            {
                SermonErrorProvider.SetError(this.AddSermonDate, "You have already added a Sermon with this Date. Only one sermon per date.");
            }
            else
            {
                SermonErrorProvider.SetError(this.AddSermonDate, string.Empty);
            }
        }

        private void SermonSpeaker_Validated(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(this.AddSermonSpeakerTxt.Text))
            {
                SermonErrorProvider.SetError(this.AddSermonSpeakerTxt, "Speaker is required.");
            }
            else
            {
                SermonErrorProvider.SetError(this.AddSermonSpeakerTxt, string.Empty);
            }
        }

        private void SermonFile_Validated(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(this.AddSermonFileTxt.Text))
            {
                SermonErrorProvider.SetError(this.AddSermonFileTxt, "Video File is required.");
            } else
            {
                string ext = this.AddSermonFileTxt.Text.Split('.').Last();
                if (ext == "mp4" || ext == "mov" || ext == "m4v" || ext == "mpg")
                {
                    SermonErrorProvider.SetError(this.AddSermonFileTxt, string.Empty);
                } else
                {
                    SermonErrorProvider.SetError(this.AddSermonFileTxt, "File must be .mp4, .mov, .mpg or .m4v format.");
                }
            }
        }

        private void SermonOutput_Validated(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(this.AddSermonOutputTxt.Text))
            {
                SermonErrorProvider.SetError(this.AddSermonOutputTxt, "Output Folder is required.");
            } else
            {
                SermonErrorProvider.SetError(this.AddSermonOutputTxt, string.Empty);
            }
        }

        #endregion

        private System.Windows.Forms.Panel AddSermonPanel;
        private System.Windows.Forms.TextBox AddSermonTitleTxt;
        private System.Windows.Forms.TextBox AddSermonScriptureTxt;
        private System.Windows.Forms.TextBox AddSermonSpeakerTxt;
        private System.Windows.Forms.DateTimePicker AddSermonDate;
        private System.Windows.Forms.Label AddSermonDateLbl;
        private System.Windows.Forms.Label AddSermonScriptureLbl;
        private System.Windows.Forms.Label AddSermonSpeakerLbl;
        private System.Windows.Forms.Label AddSermonTitleLbl;
        private System.Windows.Forms.Button AddSermonFileBtn;
        private System.Windows.Forms.TextBox AddSermonFileTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddSermonCancelBtn;
        private System.Windows.Forms.Button AddSermonOkBtn;
        private System.Windows.Forms.ErrorProvider SermonErrorProvider;
        private System.Windows.Forms.ErrorProvider SermonStatusProvider;
        private TextBox AddSermonOutputTxt;
        private Button AddSermonOutputBtn;

        static HttpClient webClient = new HttpClient();
    }
}