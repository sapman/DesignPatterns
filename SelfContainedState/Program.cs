using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfContainedState
{
    class Program
    {
        public const string PASSWORD = "123456";
        public static void Main(string[] args)
        {
            Context ctx = new Context();
            ctx.Login("123456");
            ctx.Restart();
            ctx.Login("1234");
            ctx.Login("1234");
            ctx.Login("1234");
            ctx.Restart();
            ctx.Login("1234");
            ctx.Login("1234");
            ctx.Login("123456");
            ctx.Login("123456");
            ctx.Login("1234");
        }
    }
}
