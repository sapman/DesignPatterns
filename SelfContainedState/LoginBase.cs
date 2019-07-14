using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfContainedState
{
    public abstract class LoginBase : ILoginState
    {
        protected Context ctx;

        public LoginBase(Context context)
        {
            this.ctx = context;
        }

        public abstract void Login(Context ctx, string password);
        public abstract void Restart(Context ctx);
    }
}
