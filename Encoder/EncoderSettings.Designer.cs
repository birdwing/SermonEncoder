namespace Encoder
{
    partial class EncoderSettings
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
            this.FFmpegPathTxt = new System.Windows.Forms.TextBox();
            this.FFmpegDirTxt = new System.Windows.Forms.TextBox();
            this.FFmpegSaveBtn = new System.Windows.Forms.Button();
            this.FFmpegCancelBtn = new System.Windows.Forms.Button();
            this.FFmpegErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.FFmpegPathBtn = new System.Windows.Forms.Button();
            this.FFmpegDirBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FFmpegErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // FFmpegPathTxt
            // 
            this.FFmpegPathTxt.Location = new System.Drawing.Point(117, 14);
            this.FFmpegPathTxt.Name = "FFmpegPathTxt";
            this.FFmpegPathTxt.Size = new System.Drawing.Size(181, 20);
            this.FFmpegPathTxt.TabIndex = 2;
            this.FFmpegPathTxt.Text = global::Encoder.Properties.Settings.Default.FFmpegPath;
            this.FFmpegPathTxt.Validating += new System.ComponentModel.CancelEventHandler(this.FFmpegPath_Validated);
            // 
            // FFmpegDirTxt
            // 
            this.FFmpegDirTxt.Location = new System.Drawing.Point(117, 44);
            this.FFmpegDirTxt.Name = "FFmpegDirTxt";
            this.FFmpegDirTxt.Size = new System.Drawing.Size(181, 20);
            this.FFmpegDirTxt.TabIndex = 3;
            this.FFmpegDirTxt.Text = global::Encoder.Properties.Settings.Default.FFmpegDir;
            this.FFmpegDirTxt.Validating += new System.ComponentModel.CancelEventHandler(this.FFmpegDir_Validated);
            // 
            // FFmpegSaveBtn
            // 
            this.FFmpegSaveBtn.Location = new System.Drawing.Point(12, 74);
            this.FFmpegSaveBtn.Name = "FFmpegSaveBtn";
            this.FFmpegSaveBtn.Size = new System.Drawing.Size(135, 23);
            this.FFmpegSaveBtn.TabIndex = 4;
            this.FFmpegSaveBtn.Text = "Save";
            this.FFmpegSaveBtn.UseVisualStyleBackColor = true;
            this.FFmpegSaveBtn.Click += new System.EventHandler(this.FFmpegSaveBtn_Click);
            // 
            // FFmpegCancelBtn
            // 
            this.FFmpegCancelBtn.Location = new System.Drawing.Point(163, 74);
            this.FFmpegCancelBtn.Name = "FFmpegCancelBtn";
            this.FFmpegCancelBtn.Size = new System.Drawing.Size(135, 23);
            this.FFmpegCancelBtn.TabIndex = 5;
            this.FFmpegCancelBtn.Text = "Cancel";
            this.FFmpegCancelBtn.UseVisualStyleBackColor = true;
            this.FFmpegCancelBtn.Click += new System.EventHandler(this.FFmpegCancelBtn_Click);
            // 
            // FFmpegErrorProvider
            // 
            this.FFmpegErrorProvider.BlinkRate = 1000;
            this.FFmpegErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.FFmpegErrorProvider.ContainerControl = this;
            // 
            // FFmpegPathBtn
            // 
            this.FFmpegPathBtn.Location = new System.Drawing.Point(12, 12);
            this.FFmpegPathBtn.Name = "FFmpegPathBtn";
            this.FFmpegPathBtn.Size = new System.Drawing.Size(99, 23);
            this.FFmpegPathBtn.TabIndex = 6;
            this.FFmpegPathBtn.Text = "FFmpeg Path";
            this.FFmpegPathBtn.UseVisualStyleBackColor = true;
            this.FFmpegPathBtn.Click += new System.EventHandler(this.FFmpegPathBtn_Click);
            // 
            // FFmpegDirBtn
            // 
            this.FFmpegDirBtn.Location = new System.Drawing.Point(12, 42);
            this.FFmpegDirBtn.Name = "FFmpegDirBtn";
            this.FFmpegDirBtn.Size = new System.Drawing.Size(99, 23);
            this.FFmpegDirBtn.TabIndex = 7;
            this.FFmpegDirBtn.Text = "FFmpeg Directory";
            this.FFmpegDirBtn.UseVisualStyleBackColor = true;
            this.FFmpegDirBtn.Click += new System.EventHandler(this.FFmpegDirBtn_Click);
            // 
            // EncoderSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 110);
            this.Controls.Add(this.FFmpegDirBtn);
            this.Controls.Add(this.FFmpegPathBtn);
            this.Controls.Add(this.FFmpegCancelBtn);
            this.Controls.Add(this.FFmpegSaveBtn);
            this.Controls.Add(this.FFmpegDirTxt);
            this.Controls.Add(this.FFmpegPathTxt);
            this.Name = "EncoderSettings";
            this.Text = "EncoderSettings";
            ((System.ComponentModel.ISupportInitialize)(this.FFmpegErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void FFmpegPath_Validated(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(this.FFmpegPathTxt.Text))
            {
                FFmpegErrorProvider.SetError(this.FFmpegPathTxt, "Path is required.");
            }
            else
            {
                FFmpegErrorProvider.SetError(this.FFmpegPathTxt, string.Empty);
            }
        }

        private void FFmpegDir_Validated(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(this.FFmpegDirTxt.Text))
            {
                FFmpegErrorProvider.SetError(this.FFmpegDirTxt, "Path is required.");
            }
            else
            {
                FFmpegErrorProvider.SetError(this.FFmpegDirTxt, string.Empty);
            }
        }
        private System.Windows.Forms.TextBox FFmpegPathTxt;
        private System.Windows.Forms.TextBox FFmpegDirTxt;
        private System.Windows.Forms.Button FFmpegSaveBtn;
        private System.Windows.Forms.Button FFmpegCancelBtn;
        private System.Windows.Forms.ErrorProvider FFmpegErrorProvider;
        private System.Windows.Forms.Button FFmpegPathBtn;
        private System.Windows.Forms.Button FFmpegDirBtn;
    }
}