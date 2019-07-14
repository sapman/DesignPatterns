using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfContainedState
{
    public class LoginFailed : LoginBase
    {
        int counter;
        public LoginFailed(Context context) : base(context)
        {
            counter = 2;
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
                counter -= 1;
                Console.WriteLine($"Bad password, {counter} more tries!");
                if (counter == 0)
                {
                    Console.WriteLine("No more tries, you are locked :( !");
                    ctx.setState(new LoginLocked(ctx));
                }
            }
        }

        public override void Restart(Context ctx)
        {
            Console.WriteLine("Restarting state");
            ctx.setState(new NewLogin(ctx));
        }
    }
}
