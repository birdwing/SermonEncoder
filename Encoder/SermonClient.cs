using System.Net;
using System.Windows.Forms;

namespace Encoder
{
    class SermonClient : WebClient
    {
        public ListViewItem Sermon { get; set; }
    }
}
