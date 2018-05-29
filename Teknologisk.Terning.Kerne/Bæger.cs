using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teknologisk.Terning.Kerne
{
    public class Bæger
    {
        private Terning[] terninger;


        public Bæger():this(5) //sender videre
        {
       
        }

        public Bæger(int antal)
        {
            terninger = new Terning[5];
            for (int i = 0; i < terninger.Length; i++)
            {
                terninger[i] = new Terning();
            }
                   
        }
        public Bæger(params int[] værdier)
        {
            terninger = new Terning[værdier.Length];
            for (int i = 0; i < terninger.Length; i++)
            {
                terninger[i] = new Terning(værdier[i]);
            }

        }


        public string Skriv()
        {
            string temp = "";
            foreach (Terning t in terninger)
            {
                temp += t.Skriv();
            }
            return temp;
        }

        public void RystIBæger()
        {
            foreach (Terning t in terninger)
            {
                t.Ryst();
            }
        }
    }
 
}

