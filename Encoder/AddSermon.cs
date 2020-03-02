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

    public partial class AddSermon : Form
    {

        public string Title { get; set; }
        public string Speaker { get; set; }
        public string Scripture { get; set; }
        public DateTime Date { get; set; }
        public string File { get; set; }
        public string Output { get; set; }
        public string Status { get; set; }

        public AddSermon(ListView Sermons)
        {
            InitializeComponent(Sermons);
        }

        private void AddSermonCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddSermonOkBtn_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();
            bool HasError = false;

            foreach (Control ctrl in this.Controls)
            {
                if(!string.IsNullOrEmpty(SermonErrorProvider.GetError(ctrl)))
                {
                    HasError = true;
                    break;
                }
            }
            
            if (!HasError)
            {
                this.Title = AddSermonTitleTxt.Text;
                this.Speaker = AddSermonSpeakerTxt.Text;
                this.Scripture = AddSermonScriptureTxt.Text;
                this.Date = AddSermonDate.Value;
                this.File = AddSermonFileTxt.Text;
                this.Output = AddSermonOutputTxt.Text;
                this.Status = "Waiting";
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void AddSermonFileBtn_Click(object sender, EventArgs e)
        {
            var fd = new OpenFileDialog();
            fd.Title = "Select Import File";
            fd.InitialDirectory = "C:\\";
            fd.RestoreDirectory = true;
            fd.Filter = "video files (*.mp4;*.mov;*.m4v;*.mpg)|*.mp4;*.mov;*.m4v;*.mpg";
            DialogResult dr = fd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                AddSermonFileTxt.Text = fd.FileName;
                this.ValidateChildren();
            }
        }

        private void AddSermonOutputBtn_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            DialogResult dr = fbd.ShowDialog();

            if (dr == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                AddSermonOutputTxt.Text = fbd.SelectedPath;
                this.ValidateChildren();
            }
        }
    }
}
