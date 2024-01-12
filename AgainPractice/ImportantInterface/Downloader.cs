using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ImportantInterface
{
    public class Downloader : IDisposable
    {
        WebClient _client;
        public Downloader()
        {
            _client = new WebClient();
        }

        public void Dispose()
        {
            _client.Dispose();
        }

        public string Download(string url)
        {
            return _client.DownloadString(url);
        }
    }
}
