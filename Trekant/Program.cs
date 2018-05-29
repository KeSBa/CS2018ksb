using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trekant
{
    class Program
    {
        static void Main(string[] args)
        {
            TreKant t = new TreKant(10, 5);
            //TreKant t2 = new TreKant();
            //t2.Grundlinje = 10;
            //t2.Højde = 21;
            //t.Grundlinje = 100;
            Console.WriteLine(t.Areal); 
        }
    }
        public class TreKant
    {
        public int Grundlinje { get; private set; }
        public int Højde { get; private set; }

        public TreKant(int grundlinje, int højde)
        {
            this.Grundlinje = grundlinje;
            this.Højde = højde;
        }
        public double Areal
        {
            get
            {
                return this.Grundlinje * this.Højde * 0.5;
            }
        }
    }

}
