using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Tabel
{
    class Program
    {
        static void Main(string[] args)
        {
            string tal = null;
            int length = 11;
            int start = 1;

            for (int i = start; i < length; i++)
            {
                for (int j = start; j < length; j++)
                {
                    tal = (j * i).ToString();
                    if (i*j > 50 )
                    {
                        Console.ForegroundColor = System.ConsoleColor.Yellow;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.Write(tal.PadLeft(4));

                }
                Console.WriteLine();
            }
        }
    }
}
