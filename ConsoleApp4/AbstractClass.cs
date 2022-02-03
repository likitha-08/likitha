using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Eating");
        }
    }

    public abstract class Animal
    {
        private string Name;

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public abstract void Eat();
    }
    class AbstractClass
    {
        public static void Main6(string[] args)
        {
            Console.WriteLine("Dog name:-");
            Dog dog = new Dog();
            dog.SetName(Console.ReadLine());
            Console.WriteLine(dog.GetName());
            dog.Eat();
        }

        public class Dog : Animal
        {
            public override void Eat()
            {
                Console.WriteLine("Eating");
            }
        }
    }
}
