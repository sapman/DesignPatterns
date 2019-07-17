using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Adapter3Dto2D : ID3Painter
    {

        ID2Painter d2Painter = new D2NicePainter();

        public void Paint3DShape(D3Shape s)
        {
            foreach(D2Shape d2 in s.GetD2Shapes())
            {
                d2Painter.Paint2DShape(d2);
            }
        }
    }
}
