using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp2
{
    class DebugLogHandler : LogHandler
    {
        public override void Log(string message, LogLevel level)
        {
            if (level == LogLevel.Debug)
                Console.WriteLine($"[DEBUG] {message}");
            else if (next != null)
                next.Log(message, level);
        }
    }
}
