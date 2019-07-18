using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Five
{
    public class FatalLogHandler : LogHandler
    {
        public override void Log(string message, LogLevel level)
        {
            Console.WriteLine("Sending SMS message to 0544824218!");
            if (level < LogLevel.Fatal && next != null)
                next.Log(message, level);
        }
    }
}
