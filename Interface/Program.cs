using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IDBFunctioner[] i  = new IDBFunctioner[2];
            i[0] = new Kunde();
            i[1] = new Vare();
            

        }
    }

    public interface IDBFunctioner
    {
        void Gem();
        void Reset();

    }

    class Kunde : IDBFunctioner
    {
        public void Gem() {
            Console.WriteLine("gmmmer kunde");
        }
        public void Reset() { }

    }
    class Vare : IDBFunctioner
    {
        public void Gem() {
            Console.WriteLine("gmmmer vare"); }

        public void Reset() { }

    }
}

