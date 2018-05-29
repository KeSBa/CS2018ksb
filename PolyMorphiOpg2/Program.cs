using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphiOpg2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog() { Name = "Viggo" };
            d.SaySome();

            //På grund af abstract kan dyr IKKE instansieres
            //Animal a = new Animal() { Name = "" };
            
            Animal[] animals = new Animal[20];
            for (int i = 0; i < animals.Length; i++)
            {
                animals[i] = Animal.RandomAnimal();
            }

            foreach (var item in animals)
            {
                item.SaySome();
            }

            Console.ReadKey();
        }

        public abstract class Animal
        {
            static System.Random randomNumber = new Random();
            public string Name { get; set; }
            public virtual void SaySome()
            {
                Console.WriteLine("I am an Animal!, my name is " + Name);
            }

            public static Animal RandomAnimal()
            {
                string path = @"x:\dyrenavne.txt";
                string[] navne = System.IO.File.ReadAllLines(path);
                int index = randomNumber.Next(0, navne.Length);
                if (index % 2 == 0)
                {
                    return new Dog() { Name = navne[index] };
                }
                else
                {
                    return new Cat() { Name = navne[index] };
                }
            }
        }
        public class Dog : Animal
        {
            public override void SaySome()
            {
                Console.WriteLine("I am a Dog!, my name is " + Name);
            }
        }
        public class Cat : Animal
        {
            public override void SaySome()
            {
                Console.WriteLine("I am a Cat!, my name is " + Name);
            }
        }
    }
}
