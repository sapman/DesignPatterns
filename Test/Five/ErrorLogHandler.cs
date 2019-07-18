using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Five
{
    class ErrorLogHandler : LogHandler
    {
        public override void Log(string message, LogLevel level)
        {
            Console.WriteLine($"Writing to /dev/null ...");
            if (level < LogLevel.Error && next != null)
                next.Log(message, level);
        }
    }
}
