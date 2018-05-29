using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandelingOpg
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Run();
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error " + ex.Message);
                Console.ReadKey();
            }
        }

        private static void Run()
        {
            try
            {
                Console.WriteLine("indtast 1. tal: ");
                int t1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("indtast 2. tal: ");
                int t2 = Convert.ToInt32(Console.ReadLine());
                int sum = t1 + t2;
                Console.WriteLine("Result is: " + sum);
                Console.ReadKey();
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error in the void  " + ex.Message);
                Console.ReadKey();
                //
                throw;
            }
            finally {}

        }
    }
}
