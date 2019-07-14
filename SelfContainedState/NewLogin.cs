using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfContainedState
{
    public class NewLogin : LoginBase
    {
        public NewLogin(Context context) : base(context)
        {
        }

        public override void Login(Context ctx, string password)
        {
            if (password == Program.PASSWORD)
            {
                Console.WriteLine("Good password :) !");
                ctx.setState(new LoginSucceeded(ctx));
            }
            else
            {
                Console.WriteLine($"Bad password, 3 more tries!");
                ctx.setState(new LoginFailed(ctx));
            }
        }

        public override void Restart(Context ctx)
        {
            Console.WriteLine("Restarting state");
            ctx.setState(new NewLogin(ctx));
        }
    }
}
