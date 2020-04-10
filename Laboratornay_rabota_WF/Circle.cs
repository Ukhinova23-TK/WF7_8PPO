using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornay_rabota_WF
{
    class Circle : Geometric_Fig
    {
        protected double l;
        public double Run_Circle()
        {
            l = s1 * Math.PI;
            return l;
        }
    }
}
