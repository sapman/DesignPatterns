using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfContainedState
{
    public interface ILoginState
    {
        void Login(Context ctx, string password);
        void Restart(Context ctx);
    }
}
