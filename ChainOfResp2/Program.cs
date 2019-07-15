using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp2
{
    class Program
    {
        static void Main(string[] args)
        {
            LogHandler fatal = new FatalLogHandler();
            LogHandler error = new ErrorLogHandler();
            LogHandler info = new InfoLogHandler();
            LogHandler debug = new DebugLogHandler();

            LogHandler logger = fatal;
            fatal.SetNext(error);
            error.SetNext(info);
            info.SetNext(debug);

            logger.Log("First", LogLevel.Fatal);
            logger.Log("Second", LogLevel.Error);
            logger.Log("Third", LogLevel.Info);
            logger.Log("Forth", LogLevel.Debug);

            // Now creating an opposite chain...
            Console.WriteLine("===============");

            fatal = new FatalLogHandler();
            error = new ErrorLogHandler();
            info = new InfoLogHandler();
            debug = new DebugLogHandler();

            logger = debug;
            debug.SetNext(info);
            info.SetNext(error);
            error.SetNext(fatal);

            logger.Log("First", LogLevel.Fatal);
            logger.Log("Second", LogLevel.Error);
            logger.Log("Third", LogLevel.Info);
            logger.Log("Forth", LogLevel.Debug);

        }
    }
}
