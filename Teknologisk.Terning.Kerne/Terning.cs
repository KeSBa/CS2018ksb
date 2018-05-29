using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teknologisk.Terning.Kerne
{
    public class Terning
    {
        private static System.Random rnd = new System.Random();
        public int Værdi { get; private set; }

        public void Ryst()
        {
            this.Værdi = rnd.Next(1, 7);
        }
        public Terning(int værdi)
        {
            this.Værdi = værdi;
        }

        public Terning()
        {
            Ryst();
        }

        public virtual string Skriv()
        {
            return $"[{this.Værdi}] ";
        }

    }
}
