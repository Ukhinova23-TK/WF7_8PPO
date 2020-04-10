using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornay_rabota_WF
{
    class Tri
    {
        private double s1, s2, s3, ug1, ug2, ug3, squ, per;
        public Tri(double st1, double st2, double ugol)
        {
            s1 = st1;
            s2 = st2;
            ug1 = ugol;
        }
        public Tri() { }
        public double _S1
        {
            get
            { return s1; }
            set
            { s1 = value; }
        }
        public double _S2
        {
            get
            { return s2; }
            set
            { s2 = value; }
        }
        public double _S3
        {
            get
            {
                return s3;
            }
        }
        public double _Ug1
        {
            get
            { return ug1; }
            set
            { ug1 = value; }
        }
        public double _Ug2
        {
            get
            { return ug2; }
        }
        public double _Ug3
        {
            get
            { return ug3; }
        }
        public double _Per
        {
            get
            { return per; }
        }
        public double _Squ
        {
            get
            { return squ; }
        }
        public double S3()
        {
            s3 = Math.Sqrt(s1 * s1 + s2 * s2 - 2 * s1 * s2 * Math.Cos(ug1 * Math.PI / 180));
            return s3;
        }
        public double Ug2()
        {
            ug2 = (s2 * s2 + s3 * s3 - s1 * s1) / (2 * s2 * s3);
            ug2 = Math.Acos(ug2) * 180 / Math.PI;
            return ug2;
        }
        public double Ug3()
        {
            if (ug2 == 0) Ug2();
            ug3 = 180 - ug1 - ug2;
            return ug3;
        }
        public double Perimetr()
        {
            if (s3 == 0) S3();
            per = s1 + s2 + s3;
            return per;
        }
        public double Square()
        {
            if (per == 0) Perimetr();
            squ = Math.Sqrt(0.5 * per * (0.5 * per - s1) * (0.5 * per - s2) * (0.5 * per - s3));
            return squ;
        }
    }
}

