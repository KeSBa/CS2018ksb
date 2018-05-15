using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbejdeMedStrenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn = "Mikkel";
            string efternavn = "Cronberg";

            string samletNavn = fornavn + " " + efternavn;

            string navnStort = samletNavn.ToUpper();
            string navnLille = samletNavn.ToLower();
            string del = samletNavn.Substring(7, 4);

            string[] strSplit = null;
            strSplit[0] = fornavn as string;
            strSplit[1] = efternavn as string;


            string[] strSplit2 = samletNavn.Split(' ');
            for (int i = 0; i < strSplit2.Length; i++)
            {
                Console.WriteLine(strSplit2[i]);
            }

            Console.WriteLine(fornavn + "\r\n\t" + efternavn);
            System.IO.File.WriteAllText("c:\\temp\\test.txt",samletNavn);

        }
    }
}
