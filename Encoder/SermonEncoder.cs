using FireEncoder;
using System.Windows.Forms;

namespace Encoder
{
    class SermonEncoder : MediaEncoder
    {
        public ListViewItem Sermon { get; set; }
        public string FFmpegVideoCmd { get; set; }
        public string FFmpegAudioCmd { get; set; }
    }
}
