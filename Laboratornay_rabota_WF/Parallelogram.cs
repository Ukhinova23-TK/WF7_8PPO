using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornay_rabota_WF
{
    class Parallelogram : Geometric_Fig
    {
        public Parallelogram() { }
        public override double Perimetr()
        {
            per = 2 * s1 + 2 * s2;
            return per;
        }
        public override double Square()
        {
            squ = s1 * s2 * Math.Sin(ug1 * Math.PI / 180);
            return squ;
        }
    }
}
