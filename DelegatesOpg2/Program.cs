using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DelegatesOpg2
{
    public delegate void Del_Action(string del_txt);

    class Program
    {
        static void Main(string[] args)
        {

            Machine m = new Machine();
            Del_Action del_Action = new Del_Action(AppendLog);
            Del_Action del_Action2 = new Del_Action(Console.WriteLine);
            del_Action.Invoke("   TEST   ");
            del_Action2.Invoke("   TEST2   ");
            m.Log = new Del_Action(Console.WriteLine);
            m.Log += AppendLog;
            
            m.Start();

        }

        static void AppendLog(string TEXT)
        {
            System.IO.File.AppendAllText(@"c:\temp\log.txt", TEXT + "\r");
        }

    }
    public class Machine
    {

        public Action<string> Log2 { get; set; }
        public Del_Action Log { get; set; }

        public void Start()
        {
            Log(DateTime.Now.ToLongTimeString() + " Start");
        }
        public void Stop()
        {
            Log(DateTime.Now.ToLongTimeString() + " Stop");
        }
    }
}
