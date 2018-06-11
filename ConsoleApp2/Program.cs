using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbFunktioner[] array = new IDbFunktioner[4];
            array[0] = new Hund();
            array[1] = new ubåd();
            array[2] = new Hund();
            array[3] = new ubåd();
            foreach (var item in array)
            {
                item.Gem();
            }
            Console.ReadKey();


        }
    }

    class Hund : IDbFunktioner
    {
        public string Navn { get; set; }
        public void Gem()
        {
            Console.WriteLine("gemmer hund");
        }
    }

    class ubåd : IDbFunktioner
    {
        public int Nummer { get; set; }
        public double Tubine { get; set; }

        public void Gem()
        {
            Console.WriteLine("gemmer ubåd");
        }
    }

    interface IDbFunktioner
    {
        void Gem();


    }

}
