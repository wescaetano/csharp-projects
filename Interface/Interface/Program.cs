using System;
using Interface;

namespace MyApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            // AdvancedCalculator
            Calculator calc = new Calculator();
            Console.WriteLine("Cosseno: " + calc.Cosine(45).ToString("F3"));
            Console.WriteLine("Seno: " + calc.Sine(45).ToString("F3"));
            Console.WriteLine("Tangente: " + calc.Tangent(45).ToString("F3"));
            Console.WriteLine();

            // BaseCalculator
            Console.WriteLine("Multiplicação: " + calc.Multiplication(5, 7).ToString("F2"));
            Console.WriteLine("Adição: " + calc.Sum(5, 7).ToString("F2"));
            Console.WriteLine("Subtração: " + calc.Subtraction(10, 7).ToString("F2"));
            Console.WriteLine("Divisão: " + calc.Division(10, 2).ToString("F2"));            
        }
    }
}
