using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeProxy
{
    public class ProxyFactory
    {
        public ClientProxy Login(string username, string password)
        {
            if (password != "Wrong")
            {
                if (username.ToLower() == "admin")
                    return new AdminProxy();
                else if (username.ToLower() == "company")
                    return new CompanyProxy();
                return new CustomerProxy();
            }
            return null;
        }
    }
}
