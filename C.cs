using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable

namespace PRG547ASSIGNMENT1
{
    public static class C
    {
        public static void Title(string s)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(s);
            Console.WriteLine();
            Console.ResetColor();
        }

        public static void Expected(string s)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Expected:");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(s);
            Console.WriteLine();
            Console.ResetColor();
        }

        public static void Actual(string s)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Actual:");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(s);
            Console.WriteLine();
            Console.ResetColor();
        }

        public static void Next()
        {
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();
        }
    }
}
