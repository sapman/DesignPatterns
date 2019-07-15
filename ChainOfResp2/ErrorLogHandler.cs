using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp2
{
    class ErrorLogHandler : LogHandler
    {
        public override void Log(string message, LogLevel level)
        {
            if (level == LogLevel.Error)
                Console.WriteLine($"[ERROR] " + message);
            else if (next != null)
                next.Log(message, level);
        }
    }
}
