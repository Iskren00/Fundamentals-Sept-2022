using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = a > b ? a : b;

            bool isTrue = 100f != 100d;
            Console.WriteLine(isTrue);
        }
    }
}
