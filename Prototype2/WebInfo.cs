using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype2
{
    class WebInfo : IPrototype<WebInfo>
    {
        public DateTime Timestamp { get; set; }
        public string Size { get; private set; }
        public string URL { get; private set; }

        public WebInfo(DateTime timestamp, string size, string url)
        {
            Timestamp = timestamp;
            Size = size;
            URL = url;
        }

        public override string ToString()
        {
            return $"{URL}: {Size} ({Timestamp.ToLongTimeString()})";
        }

        public WebInfo Clone()
        {
            return new WebInfo(new DateTime(Timestamp.Ticks), Size, URL);
        }
    }
}
