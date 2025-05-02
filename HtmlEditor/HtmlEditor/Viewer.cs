using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HtmlEditor
{
    public class Viewer
    {
        public static void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO VISUALIZAÇÃO");
            Console.WriteLine("-----------------");
            Replace(text);
            Console.WriteLine("-----------------");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Menu.Show();
        }

        public static void Replace(string text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>", RegexOptions.IgnoreCase);

            int lastIndex = 0;
            foreach (Match match in strong.Matches(text))
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(text.Substring(lastIndex, match.Index - lastIndex));

             
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(match.Groups[1].Value);

                lastIndex = match.Index + match.Length;
            }

            Console.ForegroundColor = ConsoleColor.Black;
            if (lastIndex < text.Length)
                Console.Write(text.Substring(lastIndex));

        }

    }

}

