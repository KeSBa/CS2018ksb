using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3_variabler
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Int32 i = 0;
            int x;

            string tmp = i.ToString();

            bool t = false;
            System.Boolean b = true;

            double k = 1234444.233;
            Console.WriteLine(k.ToString("N3"));

            int e1;
            double e2;
            bool e3;

            System.DateTime d = DateTime.MinValue;
            DateTime d2 = DateTime.Now;
            DateTime d3 = new DateTime(2018, 12, 24);

            Console.WriteLine(d3.ToString("yyyy dddd"));

            TimeSpan ts1 = d3.Subtract(d2);
            Console.WriteLine(ts1.TotalMinutes);

            TimeSpan ts2 = new TimeSpan(14, 00, 00);
            Console.WriteLine(ts2);

             

           

        }
    }
}
