using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    // non touchable class
    // 3rd party
    // very old - chanigng it will be danger ....
    public class D2NicePainter : ID2Painter
    {
        public void Paint2DShape(D2Shape s)
        {

            Console.WriteLine("Printing nicely " + s);

        }
    }
}
