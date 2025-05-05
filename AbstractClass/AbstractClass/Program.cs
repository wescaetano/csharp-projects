using System;
using AbstractClass;

namespace MyApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person();
            person.Speak();
            person.Walk();
            person.Jump();
        }
    }
}