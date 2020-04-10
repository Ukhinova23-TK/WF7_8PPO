using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornay_rabota_WF
{
    abstract class Geometric_Fig : Geometric
    {
        protected double s2, ug1, per, squ;
        public double _S2
        {
            get => s2;
            set => s2 = value;
        }
        public double _Ug1
        {
            get => ug1;
            set => ug1 = value;
        }
        public Geometric_Fig() { }
        public virtual double Perimetr()
        {
            return per;
        }
        public virtual double Square()
        {
            return squ;
        }

    }
}
