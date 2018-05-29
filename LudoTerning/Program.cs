using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LudoTerning
{
    class Program
    {
        static void Main(string[] args)
        {
            Teknologisk.Terning.Kerne.Terning t1 = new Teknologisk.Terning.Kerne.Terning();
            LudoTerning l = new LudoTerning();
            Console.WriteLine(l.Skriv());
            Console.WriteLine(l.IsGlobus());
            Console.WriteLine(l.IsStar());
                        

            Console.ReadKey();
        }
    }

    class LudoTerning : Teknologisk.Terning.Kerne.Terning
    {
        public bool IsGlobus()
        {
            return this.Værdi == 3;
        }
        public bool IsStar()
        {
            return this.Værdi == 5;
        }
        public LudoTerning() : base() { }

        public LudoTerning(int værdi) : base(værdi) { }
        
        

        public override string Skriv()
        {
            switch (this.Værdi)
            {
                case 3:
                    return "[G] ";
                case 5:
                    return "[S] ";
                default:
                    return base.Skriv();

            }
        }
    }

}
