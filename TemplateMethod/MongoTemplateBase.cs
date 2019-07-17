using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPro
{
    abstract class MongoTemplateBase : TemplateQueryRunner
    {
        protected override void CloseDbConnection()
        {
            Console.WriteLine("Mongo closed connection");
        }

        protected override void CreateDbConnection()
        {
            Console.WriteLine("Mongo created connection");
        }

        protected override void OpenDbConnection()
        {
            Console.WriteLine("Mongo openned connection");
        }
    }
}
