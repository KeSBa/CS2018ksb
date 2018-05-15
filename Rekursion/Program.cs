using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Print(1, 10);
        
        }

        static void Print(int start, int stop)
        {
            Console.WriteLine(start);
            if (start==stop)
            {
                return;
                                    
            }
            start++;
            Print(start, stop);
        }

    }
}
