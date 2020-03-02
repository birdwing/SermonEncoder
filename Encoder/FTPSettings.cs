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
    public partial class FTPSettings : Form
    {
        public FTPSettings()
        {
            InitializeComponent();
        }

        private void FTPSaveBtn_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();
            bool HasError = false;

            foreach (Control ctrl in this.Controls)
            {
                if (!string.IsNullOrEmpty(FTPErrorProvider.GetError(ctrl)))
                {
                    HasError = true;
                    break;
                }
            }

            if (!HasError)
            {
                Properties.Settings.Default.FTPProtocol = FTPProtocolBox.Text;
                Properties.Settings.Default.FTPHost = FTPHostTxt.Text;
                Properties.Settings.Default.FTPPort = FTPPortTxt.Text;
                Properties.Settings.Default.FTPDir = FTPDirTxt.Text;
                Properties.Settings.Default.FTPUsername = FTPUsernameTxt.Text;
                Properties.Settings.Default.FTPPassword = FTPPasswordTxt.Text;
                Properties.Settings.Default.Save();
                this.Close();
            }
        }

        private void FTPCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FTPProtocolBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (FTPProtocolBox.Text)
            {
                case "FTP":
                    FTPHostLbl.Text = "Host";
                    FTPPortTxt.Enabled = true;
                    break;
                case "Amazon S3":
                    FTPHostLbl.Text = "Bucket";
                    FTPPortTxt.Text = "443";
                    FTPPortTxt.Enabled = false;
                    break;
                default:
                    FTPHostLbl.Text = "Host";
                    FTPPortTxt.Enabled = true;
                    break;
            }
        }
    }
}
