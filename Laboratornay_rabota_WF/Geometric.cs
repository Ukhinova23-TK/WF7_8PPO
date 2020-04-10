using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornay_rabota_WF
{
    abstract class Geometric
    {
        protected double s1, x1, y1;
        public double _S1
        {
            get => s1;
            set => s1 = value;
        }
        public double _X1
        {
            get => x1;
            set => x1 = value;
        }
        public double _Y1
        {
            get => y1;
            set => y1 = value;
        }
        public Geometric() { }
    }
}
