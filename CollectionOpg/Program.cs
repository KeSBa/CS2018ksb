using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionOpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Bunke b = new Bunke();
            b.AddCard(new Kort() { Kulør = "Spar", Value = 2 });
            b.AddCard(new Kort() { Kulør = "Hjerter", Value = 14 });
            b.AddCard(new Kort() { Kulør = "Ruder", Value = 3 });
            b.Vis();
            var k = b.RemoveCard();
            Console.WriteLine();
            Console.WriteLine(k.ToString()); //to string er overided i Console.
            Console.WriteLine();
            b.Vis();
            Console.ReadKey();

        }

        public class Kort
        {
            public string Kulør { get; set; }
            public int Value { get; set; }
            public override string ToString()
            {
                return this.Kulør + " " +this.Value;
            }
        }

        public class Bunke
        {
            private Stack<Kort> bunke = new Stack<Kort>();

            public void AddCard(Kort k)
            {
                bunke.Push(k);
            }

            public Kort RemoveCard()
            {
                if (bunke.Count > 0) return bunke.Pop(); 
                return null;
            }

            public void Vis() {
                foreach (var item in bunke)
                {
                    Console.WriteLine(item);
                }
            }
         
        }

    }
}
