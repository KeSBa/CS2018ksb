using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomTrueFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomPlus rplus = new RandomPlus();
            Console.WriteLine(rplus.NextBool());
            Console.WriteLine(rplus.NextBool2());
        }
    }
    class RandomPlus : System.Random
    {
       public bool NextBool()
        {
            return this.Next(0, 2) < 1;
        }
        public (bool,int) NextBool2()
        {
            int n = this.Next(0, 2);
            if (n < 1)
                return (true, n);
            else
                return (false, n);
        }
    }


}
