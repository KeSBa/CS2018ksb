using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgenskabsOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            Vare v = new Vare();
            v.Navn = "Cola";
            v.Pris = 100;
            Console.WriteLine(v.PrisMedMoms());
            Vare v2 = new Vare("Tandpasta", 200);
            Console.WriteLine(v2.PrisMedMoms());
        }
    }

    public class Vare
    {
        public Vare() { }

        public Vare(string navn, double pris)
        {
            this.Pris = pris;
            this.Navn = navn;
        }



        private string _navn;

        public string Navn
        {
            get
            {
                Console.WriteLine("Nu aflæses navn");
                return _navn; }
            set
            {
                Console.WriteLine("Nu tildeles navn");
                _navn = value; }
        }

        private double _pris;

        public double Pris
        {
            get {
                Console.WriteLine("Nu aflæses pris");
                return _pris; }
            set {
                Console.WriteLine("Nu tildeles pris");
                _pris = value; }
        }

        public double PrisMedMoms()
        {
            return this._pris * 1.25;
        }



    }
}
