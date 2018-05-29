using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphyOpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person() { Efternavn = "Hansen", Fornavn = "Bo" };
            Person e = new Elev() { Efternavn = "Has", Fornavn = "Ulrik", ClassRoom = "A3" };
            Person i = new Instruktør() { Efternavn = "Nielsen", Fornavn = "Hans", KeyId = 122 };

            //p.Skriv();
            //e.Skriv();
            //i.Skriv();

            Person[] lst = new Person[3];
            lst[0] = p; // objekt af person
            lst[1] = e; // objekt af elev
            lst[2] = i; // objekt af instruktør
            foreach (var item in lst)
            {
                item.Skriv();
            }

            Console.ReadKey();
        }
    }
    class Person
    {

        public string Fornavn { get; set; }
        public string Efternavn { get; set; }

        public virtual void Skriv()
        {
            Console.WriteLine($"{Fornavn} {Efternavn}");
        } 


    }
    class Elev:Person
    {
        public string ClassRoom { get; set; }
        public override void Skriv()
        {
            Console.WriteLine($"{Fornavn} {Efternavn} {ClassRoom}");
        }
    }
    class Instruktør : Person
    {
        public int KeyId { get; set; }
        public override void Skriv()
        {
            Console.WriteLine($"{Fornavn} {Efternavn} {KeyId}");
        }

    }
}
