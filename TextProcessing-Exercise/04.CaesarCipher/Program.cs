using System;
using System.Text;

namespace _04.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            int asciiNum = 0;
            foreach (char item in input)
            {
                asciiNum = item + 3;
                sb.Append((char)asciiNum);
            }

            Console.WriteLine(sb);
        }
    }
}
