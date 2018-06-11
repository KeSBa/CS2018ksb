using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund[] hunds = new Hund[2];
            hunds[0] = new Hund() { Alder = 10, Navn = "bu" };
            hunds[1] = new Hund() { Alder = 4, Navn = "molly" };
            System.Array.Sort(hunds);
            foreach (var item in hunds)
            {
                Console.WriteLine(item.Navn);
            }
            Console.ReadKey();
        }
    }
    class Hund : System.IComparable
    {
        public string Navn { get; set; }
        public int Alder { get; set; }

        public int CompareTo(object obj)
        {
            Hund h = obj as Hund;
            if (h.Alder > this.Alder) return -1;
            if (h.Alder < this.Alder) return 1;
            return 0;

        }
    }

}
