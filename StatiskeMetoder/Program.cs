using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatiskeMetoder
{
    class Program
    {
        static void Main(string[] args)
        {
            double Areal = ArealBeregninger.BeregnArealFirkant(10, 10);

            Console.WriteLine(ArealBeregninger.BeregnArealCirkel(10));
            Console.WriteLine(ArealBeregninger.BeregnArealFirkant(10,5));
        }

    }
    static class ArealBeregninger
    {
        public static double BeregnArealFirkant( double h, double b)
        {
            return h * b;
        }
        public static double BeregnArealCirkel(double r)
        {
            return Math.Pow(r, 2) * System.Math.PI;
        }
    }
}

