using System;
using System.Reflection;

namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintTheResult(input);

        }
        static void PrintTheResult(string input)
        {
            int middle = 0;

            if (input.Length % 2 == 0)
            {
                middle = input.Length / 2;
                int secondmiddle = middle - 1;

                Console.WriteLine($"{input[secondmiddle]}{input[middle]}");

            }
            else
            {
                middle = Math.Abs(input.Length / 2);

                Console.WriteLine(input[middle]);
            }
        }
    }
}
