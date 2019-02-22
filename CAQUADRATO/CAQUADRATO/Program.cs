using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAQUADRATO
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
    class Program
    {
        static void LEGGI (out double X, out double Y, out double L)
        {
            bool OK;
            X = 0;
            Y = 0;
            L = 1;
            do
            {
                OK = true;
                try
                {
                    Console.Write("Ascissa centro: ");
                    X = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception ERR)
                {
                    Console.WriteLine(ERR.Message);
                    OK = false;
                }
            }while(!OK);
            do
            {
                OK = true;
                try
                {
                    Console.Write("Ordinata centro: ");
                    Y = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception ERR)
                {
                    Console.WriteLine(ERR.Message);
                    OK = false;
                }
            } while (!OK);
            do
            {
                OK = true;
                try
                {
                    Console.Write("Lato: ");
                    L = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception ERR)
                {
                    Console.WriteLine(ERR.Message);
                    OK = false;
                }
            } while (!OK);
        }
        static void Main(string[] args)
        {
            double X, Y, L;
            QUADRATO Q1, Q2;

            try
            {
                LEGGI(out X, out Y, out L);
                Q1 = new QUADRATO(X, Y, L);
                try
                {
                    LEGGI(out X, out Y, out L);
                    Q2 = new QUADRATO(X, Y, L);
                    Console.WriteLine("L'area del quadrato Q1 è {0}", Q1.AREA());
                    Console.WriteLine("L'area del quadrato Q2 è {0}", Q2.AREA());
                }
                catch (Exception E)
                {
                    Console.WriteLine("Problema Q2 " + E.Message);

                }
            }
            catch (Exception E)
            {
                Console.WriteLine("Problema Q1 " + E.Message);
            }
            Console.ReadKey();
                }
        }
    }

