namespace Encoder
{
    partial class FTPSettings
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
            this.components = new System.ComponentModel.Container();
            this.FTPHostLbl = new System.Windows.Forms.Label();
            this.FTPPortLbl = new System.Windows.Forms.Label();
            this.FTPDirLbl = new System.Windows.Forms.Label();
            this.FTPUsernamelbl = new System.Windows.Forms.Label();
            this.FTPPasswordLbl = new System.Windows.Forms.Label();
            this.FTPHostTxt = new System.Windows.Forms.TextBox();
            this.FTPPortTxt = new System.Windows.Forms.TextBox();
            this.FTPDirTxt = new System.Windows.Forms.TextBox();
            this.FTPUsernameTxt = new System.Windows.Forms.TextBox();
            this.FTPPasswordTxt = new System.Windows.Forms.TextBox();
            this.FTPSaveBtn = new System.Windows.Forms.Button();
            this.FTPCancelBtn = new System.Windows.Forms.Button();
            this.FTPErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.FTPProtocolLbl = new System.Windows.Forms.Label();
            this.FTPProtocolBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.FTPErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // FTPHostLbl
            // 
            this.FTPHostLbl.AutoSize = true;
            this.FTPHostLbl.Location = new System.Drawing.Point(12, 42);
            this.FTPHostLbl.Name = "FTPHostLbl";
            this.FTPHostLbl.Size = new System.Drawing.Size(29, 13);
            this.FTPHostLbl.TabIndex = 0;
            // 
            // FTPPortLbl
            // 
            this.FTPPortLbl.AutoSize = true;
            this.FTPPortLbl.Location = new System.Drawing.Point(12, 68);
            this.FTPPortLbl.Name = "FTPPortLbl";
            this.FTPPortLbl.Size = new System.Drawing.Size(26, 13);
            this.FTPPortLbl.TabIndex = 1;
            this.FTPPortLbl.Text = "Port";
            // 
            // FTPDirLbl
            // 
            this.FTPDirLbl.AutoSize = true;
            this.FTPDirLbl.Location = new System.Drawing.Point(12, 94);
            this.FTPDirLbl.Name = "FTPDirLbl";
            this.FTPDirLbl.Size = new System.Drawing.Size(29, 13);
            this.FTPDirLbl.TabIndex = 2;
            this.FTPDirLbl.Text = "Path";
            // 
            // FTPUsernamelbl
            // 
            this.FTPUsernamelbl.AutoSize = true;
            this.FTPUsernamelbl.Location = new System.Drawing.Point(12, 120);
            this.FTPUsernamelbl.Name = "FTPUsernamelbl";
            this.FTPUsernamelbl.Size = new System.Drawing.Size(55, 13);
            this.FTPUsernamelbl.TabIndex = 3;
            this.FTPUsernamelbl.Text = "Username";
            // 
            // FTPPasswordLbl
            // 
            this.FTPPasswordLbl.AutoSize = true;
            this.FTPPasswordLbl.Location = new System.Drawing.Point(14, 146);
            this.FTPPasswordLbl.Name = "FTPPasswordLbl";
            this.FTPPasswordLbl.Size = new System.Drawing.Size(53, 13);
            this.FTPPasswordLbl.TabIndex = 4;
            this.FTPPasswordLbl.Text = "Password";
            // 
            // FTPHostTxt
            // 
            this.FTPHostTxt.Location = new System.Drawing.Point(73, 39);
            this.FTPHostTxt.Name = "FTPHostTxt";
            this.FTPHostTxt.Size = new System.Drawing.Size(187, 20);
            this.FTPHostTxt.TabIndex = 5;
            this.FTPHostTxt.Text = global::Encoder.Properties.Settings.Default.FTPHost;
            this.FTPHostTxt.Validating += new System.ComponentModel.CancelEventHandler(this.FTPHost_Validated);
            // 
            // FTPPortTxt
            // 
            this.FTPPortTxt.Location = new System.Drawing.Point(73, 65);
            this.FTPPortTxt.Name = "FTPPortTxt";
            this.FTPPortTxt.Size = new System.Drawing.Size(187, 20);
            this.FTPPortTxt.TabIndex = 6;
            this.FTPPortTxt.Text = global::Encoder.Properties.Settings.Default.FTPPort;
            this.FTPPortTxt.Validating += new System.ComponentModel.CancelEventHandler(this.FTPPort_Validated);
            // 
            // FTPDirTxt
            // 
            this.FTPDirTxt.Location = new System.Drawing.Point(73, 91);
            this.FTPDirTxt.Name = "FTPDirTxt";
            this.FTPDirTxt.Size = new System.Drawing.Size(187, 20);
            this.FTPDirTxt.TabIndex = 7;
            this.FTPDirTxt.Text = global::Encoder.Properties.Settings.Default.FTPDir;
            // 
            // FTPUsernameTxt
            // 
            this.FTPUsernameTxt.Location = new System.Drawing.Point(73, 117);
            this.FTPUsernameTxt.Name = "FTPUsernameTxt";
            this.FTPUsernameTxt.Size = new System.Drawing.Size(187, 20);
            this.FTPUsernameTxt.TabIndex = 8;
            this.FTPUsernameTxt.Text = global::Encoder.Properties.Settings.Default.FTPUsername;
            this.FTPUsernameTxt.Validating += new System.ComponentModel.CancelEventHandler(this.FTPUsername_Validated);
            // 
            // FTPPasswordTxt
            // 
            this.FTPPasswordTxt.Location = new System.Drawing.Point(73, 143);
            this.FTPPasswordTxt.Name = "FTPPasswordTxt";
            this.FTPPasswordTxt.PasswordChar = '*';
            this.FTPPasswordTxt.Size = new System.Drawing.Size(187, 20);
            this.FTPPasswordTxt.TabIndex = 9;
            this.FTPPasswordTxt.Text = global::Encoder.Properties.Settings.Default.FTPPassword;
            this.FTPPasswordTxt.Validating += new System.ComponentModel.CancelEventHandler(this.FTPPassword_Validated);
            // 
            // FTPSaveBtn
            // 
            this.FTPSaveBtn.Location = new System.Drawing.Point(73, 169);
            this.FTPSaveBtn.Name = "FTPSaveBtn";
            this.FTPSaveBtn.Size = new System.Drawing.Size(89, 23);
            this.FTPSaveBtn.TabIndex = 10;
            this.FTPSaveBtn.Text = "Save";
            this.FTPSaveBtn.UseVisualStyleBackColor = true;
            this.FTPSaveBtn.Click += new System.EventHandler(this.FTPSaveBtn_Click);
            // 
            // FTPCancelBtn
            // 
            this.FTPCancelBtn.Location = new System.Drawing.Point(168, 169);
            this.FTPCancelBtn.Name = "FTPCancelBtn";
            this.FTPCancelBtn.Size = new System.Drawing.Size(92, 23);
            this.FTPCancelBtn.TabIndex = 11;
            this.FTPCancelBtn.Text = "Cancel";
            this.FTPCancelBtn.UseVisualStyleBackColor = true;
            this.FTPCancelBtn.Click += new System.EventHandler(this.FTPCancelBtn_Click);
            // 
            // FTPErrorProvider
            // 
            this.FTPErrorProvider.BlinkRate = 1000;
            this.FTPErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.FTPErrorProvider.ContainerControl = this;
            // 
            // FTPProtocolLbl
            // 
            this.FTPProtocolLbl.AutoSize = true;
            this.FTPProtocolLbl.Location = new System.Drawing.Point(12, 15);
            this.FTPProtocolLbl.Name = "FTPProtocolLbl";
            this.FTPProtocolLbl.Size = new System.Drawing.Size(46, 13);
            this.FTPProtocolLbl.TabIndex = 12;
            this.FTPProtocolLbl.Text = "Protocol";
            // 
            // FTPProtocolBox
            // 
            this.FTPProtocolBox.FormattingEnabled = true;
            this.FTPProtocolBox.Items.AddRange(new object[] {
            "FTP",
            "Amazon S3"});
            this.FTPProtocolBox.Location = new System.Drawing.Point(73, 12);
            this.FTPProtocolBox.Name = "FTPProtocolBox";
            this.FTPProtocolBox.Size = new System.Drawing.Size(187, 21);
            this.FTPProtocolBox.TabIndex = 13;
            this.FTPProtocolBox.Text = global::Encoder.Properties.Settings.Default.FTPProtocol;
            this.FTPProtocolBox.SelectedIndexChanged += new System.EventHandler(this.FTPProtocolBox_SelectedIndexChanged);
            this.FTPProtocolBox.Validating += new System.ComponentModel.CancelEventHandler(this.FTPProtocol_Validated);
            // 
            // FTPSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 209);
            this.Controls.Add(this.FTPProtocolBox);
            this.Controls.Add(this.FTPProtocolLbl);
            this.Controls.Add(this.FTPCancelBtn);
            this.Controls.Add(this.FTPSaveBtn);
            this.Controls.Add(this.FTPPasswordTxt);
            this.Controls.Add(this.FTPUsernameTxt);
            this.Controls.Add(this.FTPDirTxt);
            this.Controls.Add(this.FTPPortTxt);
            this.Controls.Add(this.FTPHostTxt);
            this.Controls.Add(this.FTPPasswordLbl);
            this.Controls.Add(this.FTPUsernamelbl);
            this.Controls.Add(this.FTPDirLbl);
            this.Controls.Add(this.FTPPortLbl);
            this.Controls.Add(this.FTPHostLbl);
            this.Name = "FTPSettings";
            this.Text = "UploadSettings";
            ((System.ComponentModel.ISupportInitialize)(this.FTPErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            //Change labels and fields based on protocol
            this.FTPHostLbl.Text = (this.FTPProtocolBox.Text == "Amazon S3") ? "Bucket" : "Host";
            this.FTPPortTxt.Enabled = (this.FTPProtocolBox.Text != "Amazon S3");
            this.FTPPortTxt.Text = (this.FTPProtocolBox.Text == "Amazon S3") ? "443" : global::Encoder.Properties.Settings.Default.FTPPort;
        }

        #endregion

        private void FTPProtocol_Validated(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(this.FTPProtocolBox.Text))
            {
                FTPErrorProvider.SetError(this.FTPProtocolBox, "Protocol is required.");
            }
            else
            {
                FTPErrorProvider.SetError(this.FTPProtocolBox, string.Empty);
            }
        }

        private void FTPHost_Validated(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(this.FTPHostTxt.Text))
            {
                FTPErrorProvider.SetError(this.FTPHostTxt, "Host is required.");
            }
            else
            {
                FTPErrorProvider.SetError(this.FTPHostTxt, string.Empty);
            }
        }

        private void FTPPort_Validated(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(this.FTPPortTxt.Text))
            {
                FTPErrorProvider.SetError(this.FTPPortTxt, "Port is required.");
            }
            else
            {
                FTPErrorProvider.SetError(this.FTPPortTxt, string.Empty);
            }
        }

        private void FTPUsername_Validated(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(this.FTPUsernameTxt.Text))
            {
                FTPErrorProvider.SetError(this.FTPUsernameTxt, "Username is required.");
            }
            else
            {
                FTPErrorProvider.SetError(this.FTPUsernameTxt, string.Empty);
            }
        }

        private void FTPPassword_Validated(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(this.FTPPasswordTxt.Text))
            {
                FTPErrorProvider.SetError(this.FTPPasswordTxt, "Password is required.");
            }
            else
            {
                FTPErrorProvider.SetError(this.FTPPasswordTxt, string.Empty);
            }
        }

        private System.Windows.Forms.Label FTPHostLbl;
        private System.Windows.Forms.Label FTPPortLbl;
        private System.Windows.Forms.Label FTPDirLbl;
        private System.Windows.Forms.Label FTPUsernamelbl;
        private System.Windows.Forms.Label FTPPasswordLbl;
        private System.Windows.Forms.TextBox FTPHostTxt;
        private System.Windows.Forms.TextBox FTPPortTxt;
        private System.Windows.Forms.TextBox FTPDirTxt;
        private System.Windows.Forms.TextBox FTPUsernameTxt;
        private System.Windows.Forms.TextBox FTPPasswordTxt;
        private System.Windows.Forms.Button FTPSaveBtn;
        private System.Windows.Forms.Button FTPCancelBtn;
        private System.Windows.Forms.ErrorProvider FTPErrorProvider;
        private System.Windows.Forms.Label FTPProtocolLbl;
        private System.Windows.Forms.ComboBox FTPProtocolBox;
        }
}