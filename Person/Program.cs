using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Efternavn = "Hansen";
            p1.Fornavn = "Per";
            p1.Fødselsår = 1934;

            int Alder = p1.EstimatedLife();
            Console.WriteLine(Alder);
            Console.ReadKey();

            Person pp = new Person()
        }

        internal class Person
        {
            public string Fornavn;
            public string Efternavn;
            public int Fødselsår;


            public string FuldtNavn()
            {
                return $"{Fornavn} {Efternavn}";
            }

            public int EstimatedLife()
            {
                int y = DateTime.Now.Year;
                return y - this.Fødselsår;
            }

            //default constructor
            public Person()
            {
                this.Fornavn = "";
                this.Efternavn = "";
            }

            //Custom constructor // chained
            
            /// <summary>
            /// Giver data om en person.
            /// </summary>
            /// <param name="efternavn"></param>
            /// <param name="fornavn"></param>
            /// <param name="fødselsår"></param>
            public Person(string efternavn, string fornavn, int fødselsår) :this()
            {
                this.Fødselsår = fødselsår;
                this.Fornavn = fornavn.ToLower();
                this.Efternavn = efternavn.ToUpper();
            }
        }
    }
}
