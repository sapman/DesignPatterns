using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class D3Shape
    {
        List<D2Shape> shapes = new List<D2Shape>();

        public List<D2Shape> GetD2Shapes()
        {
            return shapes;
        }
    }
}
