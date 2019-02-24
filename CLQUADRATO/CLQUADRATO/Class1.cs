using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLQUADRATO
{
    public class QUADRATO
    {
        private double L;
        private double X;
        private double Y;

        public QUADRATO(double l, double x, double y)
        {
            XP = x;
            YP = y;
            LP = l;
        }

        //accessor

        public double XP
        {
            get { return X; }
            set { X = value; }
        }
        public double YP
        {
            get { return Y; }
            set { Y = value; }
        }
        public double LP
        {
            get { return L; }
            set { L = value; }
        }
        //operazioni
        public double AREA()
        {
            return Math.Pow(L, 2);
        }
        public double PERIMETRO()
        {
            return 4 * L;
        }
    }
}
