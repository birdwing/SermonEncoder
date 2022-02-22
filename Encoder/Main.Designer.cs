namespace Encoder
{
    partial class Sermons
    {
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
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Waiting", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Processing", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Uploading", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Completed", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sermons));
            this.QueueLst = new System.Windows.Forms.ListView();
            this.SermonTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SermonSpeaker = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SermonScripture = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SermonDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SermonFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OutputFolder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SermonStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QueueLbl = new System.Windows.Forms.Label();
            this.AddSermonBtn = new System.Windows.Forms.Button();
            this.RemoveSermonBtn = new System.Windows.Forms.Button();
            this.ProcessBtn = new System.Windows.Forms.Button();
            this.FTPSettingsBtn = new System.Windows.Forms.Button();
            this.FFmpegSettingsBtn = new System.Windows.Forms.Button();
            this.ShutdownChk = new System.Windows.Forms.CheckBox();
            this.FileStartOffset = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // QueueLst
            // 
            this.QueueLst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SermonTitle,
            this.SermonSpeaker,
            this.SermonScripture,
            this.SermonDate,
            this.SermonFile,
            this.OutputFolder,
            this.FileStartOffset,
            this.SermonStatus});
            this.QueueLst.FullRowSelect = true;
            listViewGroup1.Header = "Waiting";
            listViewGroup1.Name = "Waiting";
            listViewGroup2.Header = "Processing";
            listViewGroup2.Name = "Processing";
            listViewGroup3.Header = "Uploading";
            listViewGroup3.Name = "Uploading";
            listViewGroup4.Header = "Completed";
            listViewGroup4.Name = "Completed";
            this.QueueLst.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4});
            this.QueueLst.HideSelection = false;
            this.QueueLst.Location = new System.Drawing.Point(17, 42);
            this.QueueLst.MultiSelect = false;
            this.QueueLst.Name = "QueueLst";
            this.QueueLst.Size = new System.Drawing.Size(1082, 364);
            this.QueueLst.TabIndex = 0;
            this.QueueLst.UseCompatibleStateImageBehavior = false;
            this.QueueLst.View = System.Windows.Forms.View.Details;
            // 
            // SermonTitle
            // 
            this.SermonTitle.Text = "Title";
            this.SermonTitle.Width = 177;
            // 
            // SermonSpeaker
            // 
            this.SermonSpeaker.Text = "Speaker";
            this.SermonSpeaker.Width = 114;
            // 
            // SermonScripture
            // 
            this.SermonScripture.Text = "Scripture";
            this.SermonScripture.Width = 116;
            // 
            // SermonDate
            // 
            this.SermonDate.Text = "Date";
            this.SermonDate.Width = 96;
            // 
            // SermonFile
            // 
            this.SermonFile.Text = "File";
            this.SermonFile.Width = 182;
            // 
            // OutputFolder
            // 
            this.OutputFolder.Text = "Output";
            this.OutputFolder.Width = 135;
            // 
            // SermonStatus
            // 
            this.SermonStatus.Text = "Status";
            this.SermonStatus.Width = 153;
            // 
            // QueueLbl
            // 
            this.QueueLbl.AutoSize = true;
            this.QueueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueueLbl.Location = new System.Drawing.Point(12, 9);
            this.QueueLbl.Name = "QueueLbl";
            this.QueueLbl.Size = new System.Drawing.Size(156, 25);
            this.QueueLbl.TabIndex = 1;
            this.QueueLbl.Text = "Sermon Queue";
            // 
            // AddSermonBtn
            // 
            this.AddSermonBtn.Location = new System.Drawing.Point(17, 417);
            this.AddSermonBtn.Name = "AddSermonBtn";
            this.AddSermonBtn.Size = new System.Drawing.Size(75, 23);
            this.AddSermonBtn.TabIndex = 2;
            this.AddSermonBtn.Text = "Add Sermon";
            this.AddSermonBtn.UseVisualStyleBackColor = true;
            this.AddSermonBtn.Click += new System.EventHandler(this.AddSermonBtn_Click);
            // 
            // RemoveSermonBtn
            // 
            this.RemoveSermonBtn.Location = new System.Drawing.Point(98, 417);
            this.RemoveSermonBtn.Name = "RemoveSermonBtn";
            this.RemoveSermonBtn.Size = new System.Drawing.Size(96, 23);
            this.RemoveSermonBtn.TabIndex = 3;
            this.RemoveSermonBtn.Text = "Remove Sermon";
            this.RemoveSermonBtn.UseVisualStyleBackColor = true;
            this.RemoveSermonBtn.Click += new System.EventHandler(this.RemoveSermonBtn_Click);
            // 
            // ProcessBtn
            // 
            this.ProcessBtn.Location = new System.Drawing.Point(963, 417);
            this.ProcessBtn.Name = "ProcessBtn";
            this.ProcessBtn.Size = new System.Drawing.Size(136, 23);
            this.ProcessBtn.TabIndex = 4;
            this.ProcessBtn.Text = "Process Waiting Sermons";
            this.ProcessBtn.UseVisualStyleBackColor = true;
            this.ProcessBtn.Click += new System.EventHandler(this.ProcessBtn_Click);
            // 
            // FTPSettingsBtn
            // 
            this.FTPSettingsBtn.Location = new System.Drawing.Point(897, 13);
            this.FTPSettingsBtn.Name = "FTPSettingsBtn";
            this.FTPSettingsBtn.Size = new System.Drawing.Size(96, 23);
            this.FTPSettingsBtn.TabIndex = 5;
            this.FTPSettingsBtn.Text = "Upload Settings";
            this.FTPSettingsBtn.UseVisualStyleBackColor = true;
            this.FTPSettingsBtn.Click += new System.EventHandler(this.FTPSettingsBtn_Click);
            // 
            // FFmpegSettingsBtn
            // 
            this.FFmpegSettingsBtn.Location = new System.Drawing.Point(999, 13);
            this.FFmpegSettingsBtn.Name = "FFmpegSettingsBtn";
            this.FFmpegSettingsBtn.Size = new System.Drawing.Size(100, 23);
            this.FFmpegSettingsBtn.TabIndex = 6;
            this.FFmpegSettingsBtn.Text = "Encoder Settings";
            this.FFmpegSettingsBtn.UseVisualStyleBackColor = true;
            this.FFmpegSettingsBtn.Click += new System.EventHandler(this.FFmpegSettingsBtn_Click);
            // 
            // ShutdownChk
            // 
            this.ShutdownChk.AutoSize = true;
            this.ShutdownChk.Checked = global::Encoder.Properties.Settings.Default.Shutdown;
            this.ShutdownChk.Location = new System.Drawing.Point(745, 421);
            this.ShutdownChk.Name = "ShutdownChk";
            this.ShutdownChk.Size = new System.Drawing.Size(212, 17);
            this.ShutdownChk.TabIndex = 7;
            this.ShutdownChk.Text = "Shutdown After All Sermons Uploaded?";
            this.ShutdownChk.UseVisualStyleBackColor = true;
            this.ShutdownChk.CheckedChanged += new System.EventHandler(this.ShutdownChk_CheckedChanged);
            // 
            // FileStartOffset
            // 
            this.FileStartOffset.Text = "Start Offset";
            this.FileStartOffset.Width = 96;
            // 
            // Sermons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 452);
            this.Controls.Add(this.ShutdownChk);
            this.Controls.Add(this.FFmpegSettingsBtn);
            this.Controls.Add(this.FTPSettingsBtn);
            this.Controls.Add(this.ProcessBtn);
            this.Controls.Add(this.RemoveSermonBtn);
            this.Controls.Add(this.AddSermonBtn);
            this.Controls.Add(this.QueueLbl);
            this.Controls.Add(this.QueueLst);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Sermons";
            this.Text = "Sermon Encoder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView QueueLst;
        private System.Windows.Forms.Label QueueLbl;
        private System.Windows.Forms.ColumnHeader SermonTitle;
        private System.Windows.Forms.ColumnHeader SermonSpeaker;
        private System.Windows.Forms.ColumnHeader SermonScripture;
        private System.Windows.Forms.ColumnHeader SermonDate;
        private System.Windows.Forms.ColumnHeader SermonFile;
        private System.Windows.Forms.ColumnHeader SermonStatus;
        private System.Windows.Forms.Button AddSermonBtn;
        private System.Windows.Forms.Button RemoveSermonBtn;
        private System.Windows.Forms.Button ProcessBtn;
        private System.Windows.Forms.ColumnHeader OutputFolder;
        private System.Windows.Forms.Button FTPSettingsBtn;
        private System.Windows.Forms.Button FFmpegSettingsBtn;
        private System.Windows.Forms.CheckBox ShutdownChk;
        private System.Windows.Forms.ColumnHeader FileStartOffset;
    }
}

