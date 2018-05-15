using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace småMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            double res = LægSammen(5, 2);

            double res2 = BeregnAreal(5);
            Console.WriteLine(res2);

            Udskriv("Dette er en Test");

            int[] løn = { 1000, 2100, 3000 };
            double avg =Gennemsnit(løn);
            Console.WriteLine(avg);
        }

        static double LægSammen(int a, int b)
        {
            return a + b;
        }

        static double BeregnAreal(int R)
        {
            return System.Math.Pow(R,2) * System.Math.PI;
        }

        static void Udskriv(string txt)
        {
            Console.WriteLine(txt);
        }

        static double Gennemsnit(int[] Månedløn)
        {
            double sum = 0;
            //foreach (int i in Månedløn)
                //{
                //    sum += Månedløn[i];
                //}
                for (int i = 0; i < Månedløn.Length; i++)
                {
                    sum += Månedløn[i];
                }
            return sum / Månedløn.Length;
        }
    }
}
