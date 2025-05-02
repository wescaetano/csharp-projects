using System;
using System.Text;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var id = Guid.NewGuid();
            //id.ToString();
            //id = new Guid("df615040-99bc-4d84-b647-690c5adf8579");
            //Console.WriteLine(id.ToString().Substring(0,8));

            var texto = " este texto é um teste ";
            //Console.WriteLine(texto.Contains("Teste"));
            //Console.WriteLine(texto.Contains("teste"));
            //Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase));

            //Console.WriteLine(texto.StartsWith("Este"));
            //Console.WriteLine(texto.StartsWith("este"));
            //Console.WriteLine(texto.EndsWith("Teste"));
            //Console.WriteLine(texto.EndsWith("teste"));

            //Console.WriteLine(texto.IndexOf("é"));
            //Console.WriteLine(texto.LastIndexOf("s"));

            //Console.WriteLine(texto.ToLower());
            //Console.WriteLine(texto.ToUpper());
            //Console.WriteLine(texto.Insert(5, "aqui "));
            //Console.WriteLine(texto.Remove(5, 5));
            //Console.WriteLine(texto.Length);
            //Console.WriteLine(texto.Replace("este", "isto"));

            //var divisao = texto.Split(" ");
            //Console.WriteLine(divisao[0]);
            //Console.WriteLine(divisao[1]);
            //Console.WriteLine(divisao[2]);
            //Console.WriteLine(divisao[3]);
            //Console.WriteLine(divisao[4]);

            //var resultado = texto.Substring(5, 5);
            //Console.WriteLine(resultado);

            Console.WriteLine(texto.Trim());

            var texto2 = new StringBuilder();

            texto2.Append("primeiro texto");
            texto2.Append(" segundo texto");

            Console.WriteLine(texto2);
        }
    }
}
