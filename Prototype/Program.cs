using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType
{
    class Program
    {
        static void Main(string[] args)
        {

            Circle c = new Circle(new Point(5, 5), 50.5);

            Console.WriteLine(c);

            DoStuffWithCircle((Circle)c.clone());

            Console.WriteLine(c);

            ShaprHolder shaprHolder = new ShaprHolder();
            shaprHolder.Add(new Rectangle(new Point(0, 0), new Point(5, 5)));
            shaprHolder.Add(new Rectangle(new Point(1, 0), new Point(5, 4)));
            
            ShaprHolder cloned = shaprHolder.clone();

            shaprHolder.Add(new Rectangle(new Point(0, 1), new Point(4, 5)));

            Console.WriteLine(shaprHolder);
            Console.WriteLine(cloned);

        }

        public static void DoStuffWithCircle(Circle c)
        {
            c.Center.X = 15;
            c.Area = -5;
        }
    }
}
