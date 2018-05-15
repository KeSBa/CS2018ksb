using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Beregn(1, 2));
            Console.WriteLine(Beregn(1, 2, 3));
            Console.WriteLine(Beregn(1, 2, 3, 4));

            Console.ReadKey(false);

        }

        static double Beregn(int a, int b)
        {
            return a + b;
            
        }
        static double Beregn(int a, int b, int c)
        {
            return Beregn (a,b) + c;
        }
        static double Beregn(int a, int b, int c, int d)
        {
            return Beregn(a, b, c) + d;
        }
    }
}
