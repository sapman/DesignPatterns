using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfContainedState
{
    public class LoginSucceeded : LoginBase
    {
        public LoginSucceeded(Context context) : base(context)
        {
        }

        public override void Login(Context ctx, string password)
        {
            Console.WriteLine("Already logged in!");
        }

        public override void Restart(Context ctx)
        {
            Console.WriteLine("Restarting state");
            ctx.setState(new NewLogin(ctx));
        }
    }
}
