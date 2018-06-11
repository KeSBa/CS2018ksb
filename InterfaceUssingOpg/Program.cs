using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUsingOpg
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader stream = System.IO.File.OpenText("x:/dyrenavne.txt"))
            {
                while (stream.Peek() != -1)
                {
                    var l = stream.ReadLine();
                    Console.WriteLine(l.ToUpper());
                }
            }
            Console.ReadKey();

            StreamReader stream1 = System.IO.File.OpenText("x:/dyrenavne.txt");
            {
                while (stream1.Peek() != -1)
                {

                    string navn = stream1.ReadLine();
                    Console.WriteLine(navn);
                }
                stream1.Close();
                stream1=null;
            }
            Console.ReadKey();

        }
    }

    //StreamReader stream = System.IO.File.OpenText("x:\dyrenane.txt");


}
