using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terning_1
{
    public class Terning
    {
        /// <summary>
        /// fields 
        /// </summary>
        private static Random rnd = new Random();
        public int værdi;
        private bool snyd;


        /// <summary>
        /// Defalut constructor
        /// </summary>
        public Terning()
        {
            this.værdi = 1;
            this.snyd = false;
        }
        /// <summary>
        /// Custom constructor
        /// </summary>
        /// <param name="snyd"></param>
        public Terning(bool snyd)
        {
            this.værdi = 1;
            this.snyd = snyd;
        }
        public void Skriv()
        {
            Console.WriteLine("[" + this.værdi + "]");

        }
        public void Ryst()
        {
            if (snyd)
            {
                this.værdi = 6;
            }
            else
            {
                this.værdi = rnd.Next(1, 7);
            }
        }
    }
}
