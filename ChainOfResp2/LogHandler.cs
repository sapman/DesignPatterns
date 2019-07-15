using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp2
{
    public abstract class LogHandler
    {
        protected LogHandler next;

        public void SetNext(LogHandler handler)
        {
            this.next = handler;
        }

        public abstract void Log(string message, LogLevel level);
    }
}
