using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphi
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.MetodeA();
            B b = new B();
            b.MetodeA();
            b.MetodeB();
            
            //kan kun se hvad der er i class A
            A aa = new B();
            aa.MetodeA();

            //type kaster
            B bb = (B)aa;
            // eller med null exception
            C cc = aa as C;

            //cc.MetodeA();


            //array
            A[] array = new A[3];
            array[0] = new A();
            array[1] = new B();
            array[2] = new C();
            foreach (var item in array)
            {
               // item.MetodeA()
            }

            Hund h = new Hund() { Navn = "viggo" };


        }
    }
    class A {
        public void MetodeA() { }
    }
    class B : A {
        public void MetodeB() { }
    }
    class C : A {}

    class Hund
    {
        public string Navn { get; set; }

        public override string ToString()
        {
            return "Vuh" + Navn;
        }

    }
}
