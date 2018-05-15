using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefVaribles
{
    class Program
    {
        static void Main(string[] args)
        {
            int j;
            double[] løn = { 2000, 4000, 500, 2500 };
            double sum = 0;
            for (int i = 0; i < løn.Length; i++)
            {
                sum += løn[i];
            }
            double gns;
            gns = sum / løn.Length;


            // instansiere variabler i stacken
            int[] test = null;
            //peger på 
            test[0] = 10;

            int[] a;
            int[] b;

            a = new int[4];
            b = new int[4];

            // skriver til to forskellige referance baseret variabler i Heap. er ens 'men' 
            a[1] = 5;
            b[1] = 5;

            //
            a=b


        }
    }
}
