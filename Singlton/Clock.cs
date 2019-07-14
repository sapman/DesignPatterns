using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class Clock
    {
        private static Clock INSTANCE;
        private static object key = new object();

        private Clock()
        {

        }

        public static Clock GetInstance()
        {
            if (INSTANCE != null)
            {
                return INSTANCE;
            }

            lock (key)
            {
                if (INSTANCE == null)
                {
                    INSTANCE = new Clock();
                }
            }
            return INSTANCE;
        }

        public void PrintTime()
        {
            Console.WriteLine(DateTime.Now.ToLongTimeString());
        }
    }
}
