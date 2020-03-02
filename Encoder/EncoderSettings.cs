using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encoder
{
    public partial class EncoderSettings : Form
    {
        public EncoderSettings()
        {
            InitializeComponent();
        }

        private void FFmpegSaveBtn_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();
            bool HasError = false;

            foreach (Control ctrl in this.Controls)
            {
                if (!string.IsNullOrEmpty(FFmpegErrorProvider.GetError(ctrl)))
                {
                    HasError = true;
                    break;
                }
            }

            if (!HasError)
            {
                Properties.Settings.Default.FFmpegPath = FFmpegPathTxt.Text;
                Properties.Settings.Default.FFmpegDir = FFmpegDirTxt.Text;
                Properties.Settings.Default.Save();
                this.Close();
            }
        }

        private void FFmpegCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FFmpegPathBtn_Click(object sender, EventArgs e)
        {
            var fd = new OpenFileDialog();
            fd.Title = "Select Import File";
            fd.InitialDirectory = "C:\\";
            fd.RestoreDirectory = true;
            fd.Filter = "FFmpeg.exe|ffmpeg.exe";
            DialogResult dr = fd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                FFmpegPathTxt.Text = fd.FileName;
                this.ValidateChildren();
            }
        }

        private void FFmpegDirBtn_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            DialogResult dr = fbd.ShowDialog();

            if (dr == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                FFmpegDirTxt.Text = fbd.SelectedPath;
                this.ValidateChildren();
            }
        }
    }
}
