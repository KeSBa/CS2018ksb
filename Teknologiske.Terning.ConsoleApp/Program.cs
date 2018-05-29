using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teknologisk.Terning.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Teknologisk.Terning.Kerne.Terning t1 = new Teknologisk.Terning.Kerne.Terning();
            Console.WriteLine(t1.Skriv());

            Teknologisk.Terning.Kerne.Terning t2 = new Teknologisk.Terning.Kerne.Terning(6);
            Console.WriteLine(t2.Skriv());
            t2.Ryst();
            Console.WriteLine(t2.Skriv());

            Kerne.Bæger b = new Kerne.Bæger();
            Console.WriteLine(b.Skriv());

            b.RystIBæger();
            Console.WriteLine(b.Skriv());

            Kerne.Bæger b2 = new Kerne.Bæger(1,1,3,4);
            Console.WriteLine(b2.Skriv());




        }
    }
}
