using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesOpg1
{

    public delegate int Del_Beregn(int aa, int bb);
    class Program
    {
        static void Main(string[] args)
        {
            Del_Beregn del_Beregn = new Del_Beregn(Plus);
            int res = Beregner(1, 34, del_Beregn);
            Console.WriteLine(res);
            res =+ Beregner(10, 2, Divider);
            Console.WriteLine(res);
            Console.ReadKey();

        }

        public static int Beregner(int a, int b, Del_Beregn del_Beregn)
        {
            return del_Beregn(a, b);
        }


        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public static int Divider(int a, int b)
        {
            return a / b;
        }
        public static int Gange(int a, int b)
        {
            return a * b;
        }

        


    }
}
