using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class D3NicePainter : ID3Painter
    {

        public void Paint3DShape(D3Shape s)
        {
            Console.WriteLine("D3 is printing not so nice ... " + s);

        }
    }

}