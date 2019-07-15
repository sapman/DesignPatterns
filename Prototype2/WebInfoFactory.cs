using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Prototype2
{
    class WebInfoFactory
    {
        Dictionary<string, WebInfo> data;
        public WebInfoFactory()
        {
            data = new Dictionary<string, WebInfo>();
        }

        public WebInfo CreateWebInfo(string url)
        {
            if (!data.ContainsKey(url))
            {
                Task<string> t = Program.WriteWebRequestSizeAsync(url);
                t.Wait();
                data[url] = new WebInfo(DateTime.Now, t.Result, url);
            }
            return data[url].Clone();
        }
    }
}
