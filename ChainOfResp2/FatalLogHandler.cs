using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp2
{
    public class FatalLogHandler : LogHandler
    {
        public override void Log(string message, LogLevel level)
        {
            if (level == LogLevel.Fatal)
                Console.WriteLine($"[FATAL] {message}");
            else if (next != null)
                next.Log(message, level);
        }
    }
}
