using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alibiDz
{
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine(" ");
        }

        public virtual string Type
        {
            get { return "Animal"; }
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Woof!");
        }

        public override string Type
        {
            get { return "Dog"; }
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Meow!");
        }

        public override string Type
        {
            get { return "Cat"; }
        }
    }

    class Bird : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Ku-Ku!");
        }

        public override string Type
        {
            get { return "Bird"; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal> { new Dog(), new Cat(), new Bird() };

            foreach (Animal animal in animals)
            {
                Console.WriteLine($"Animal Type: {animal.Type}, Sound: "); animal.Speak();
            }
        }
    }

}
