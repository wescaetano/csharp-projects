﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HtmlEditor
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOptions();
            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);

        }

        public static void DrawScreen()
        {
            Console.Write("+");
            for(int i=0; i<30; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");

         

            for (int lines = 0; lines < 10; lines++)
            {
                Console.Write("|");
                for(int i=0; i<30; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }

            Console.Write("+");
            for(int i=0; i<30; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("---- Editor HTML ----");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("2 - Abrir arquivo");
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("-----------------------");
            Console.SetCursorPosition(3, 7);
            Console.Write("Escolha uma opção: ");
        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 0:
                    System.Environment.Exit(0);
                    break;
                case 1:
                    Editor.Show();
                    break;
                case 2:
                    Console.Write("AbrirArquivo()");
                    break;
                default:
                    Console.Write("Opção inexistente!");
                    break;
            }
        }
    }
}
