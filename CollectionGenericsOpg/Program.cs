using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionGenericsOpg
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons =  new List<Person>();
            persons.Add(new Person() { Id = 1, Navn = "M" });
            persons.Add(new Person() { Id = 2, Navn = "T" });
            persons.Add(new Person() { Id = 3, Navn = "P" });

            foreach (var item in persons)
            {
                Console.WriteLine(item.Navn);
            }
            Dictionary<int, Person> persons2 = new Dictionary<int, Person>();
            persons2.Add(-1, new Person() { Id = 2, Navn = "T" });
            persons2.Add(1, new Person() { Id = 3, Navn = "P" });
            persons2.Add(2, new Person() { Id = 1, Navn = "M" });

            var p = persons2[-1];
            Console.WriteLine(p.Navn);

            Console.ReadKey();
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string Navn { get; set; }
    }
}
