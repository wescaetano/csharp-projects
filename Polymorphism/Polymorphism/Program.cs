using System;
using Polymorphism;

namespace MyApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Sound();
            Console.WriteLine();
            
            Animal dog = new Dog();
            dog.Sound();
            Console.WriteLine();
            
            Animal cat = new Cat();
            cat.Sound();
            Console.WriteLine();
        }
    }
}


