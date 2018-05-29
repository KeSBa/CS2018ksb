using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person() { Navn = "AA" };
            p.Skriv();

            Kursist k = new Kursist() { Navn = "BB" };
            k.Skriv();
            
            Instruktør i = new Instruktør() { Navn = "CC" };
            i.Skriv();

            HjælpeLærer h = new HjælpeLærer() { Navn = "DD" };
            h.Skriv();
            
            //polymorphy
            Person[] persons = new Person[2];
            persons[0] = new Person { Navn = "P" };
            persons[1] = new Kursist { Navn = "K" };

        }


    }
    class Person
    {
        public string Navn { get; set; }

        public Person()
        {
            this.Navn = "";
        }
        public Person(string navn)
        {
            this.Navn = navn;
        }
        //må godt overskrives af under klasser - til polymorphi
        public virtual void Skriv()
        {
            Console.WriteLine("jeg er en person og hedder " + this.Navn);
        }
    }

    class Kursist : Person {
        public string KursisId { get; set; }


        public Kursist() : this("") 
        {
            
        }

        public Kursist(string navn ) : base()
        {
            this.KursisId = "1";
        }
        public void SkrivBevis() { }

        // overskiver Persons' metode skriv... - til polymorphi
        public override void Skriv()
        {
            Console.WriteLine("jeg er en kursists og hedder " + this.Navn);
        }

    }
    class Instruktør : Person
    {
        public DateTime Ansat { get; set; }
        public void SkrivLønSeddel() { }

        public override void Skriv()
        {
            Console.WriteLine("jeg er en instuktør og hedder " + this.Navn);
        }
    }
    // kan ikke nedarves videre...sealed
    sealed class HjælpeLærer : Instruktør {
        // henter default construct fra moder, hvis denne ikke findes går den til moders moder..
        
            //public HjælpeLærer()
        //{
                
        //}
        public int PraktikPerideo { get; set; }
        public void OpretLogin() { }    

    }



}

