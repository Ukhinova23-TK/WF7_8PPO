using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornay_rabota_WF
{
    class Triangle : Geometric_Fig
    {
        protected double s3;
        public Triangle() { }
        public double _S3
        {
            get => s3 = Math.Sqrt(s1 * s1 + s2 * s2 - 2 * s1 * s2 * Math.Cos(ug1 * Math.PI / 180));
        }
        public override double Perimetr()
        {
            per = s1 + s2 + _S3;
            return per;
        }
        public override double Square()
        {
            squ = 0.5 * s1 * s2 * Math.Sin(ug1 * Math.PI / 180);
            return squ;
        }
    }
}
