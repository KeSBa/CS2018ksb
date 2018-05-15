using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace månedsLønGennmsnit
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] iMånedsLøn = {500, 3200, 1002, 1233, 2333 };
            double iSum = 0;

            for (int i = 0; i < iMånedsLøn.Length; i++)
            {
                iSum += iMånedsLøn[i];
            }
            double gns;
            gns = iSum / iMånedsLøn.Length;
            for (int i = 0; i < iMånedsLøn.Length; i++)
            {
                Console.WriteLine(iMånedsLøn[i]);
            }
            Console.WriteLine("Gennemsnit " + gns.ToString("N2"));


            // ekstra laver en sorteret kopi.
            System.Array.Sort(iMånedsLøn);
            int[] sort =((int[]) iMånedsLøn.Clone());

            int[] sort2 = (iMånedsLøn.Clone()) as int[]; //tillader null-exception, men skal man skal selv teste for fejlen efterfølgende


        }
    }
}
