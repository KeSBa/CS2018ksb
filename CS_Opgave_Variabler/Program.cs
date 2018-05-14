using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Opgave_Variabler
{
    class Program
    {
        static void Main(string[] args)
        {

            //del 1
            Int32 heltal = 10;
            ++heltal;
            --heltal;
            heltal += 20;
            Console.WriteLine("Værdien er: " + heltal.ToString());

            //del 2
            Double kommatal = 12.5;
            ++kommatal;
            --kommatal;
            kommatal *= 2;
            Console.WriteLine("Værdien på 'kommatal' er: " + kommatal.ToString());

            //del 3
            FiltyperEnum ft = FiltyperEnum.csv;
            Console.WriteLine(ft.ToString());
            //Console.WriteLine(Convert.ToUInt32);

            //del 4
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime.ToString("ddMMyy"));
            Console.WriteLine(dateTime.ToString("dd-MM-yyyy"));
            Console.WriteLine(dateTime.ToString("M/d-yy"));

            //del 5
            Person p = new Person();
            p.id = 1;
            p.navn = "Mikkel";
            Console.WriteLine(p.navn);

        }
    }
    public enum FiltyperEnum
    {
        pdf,
        txt,
        csv
    
    }
    //del 5
    public struct Person
    {
        public int id;
        public string navn;
    }


}
