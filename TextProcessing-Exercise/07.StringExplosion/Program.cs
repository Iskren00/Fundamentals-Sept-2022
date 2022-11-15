using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace _07.StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int detonate = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (detonate > 0 && input[i] != '>')
                {
                    input = input.Remove(i, 1);
                    detonate--;
                    i--;
                }
                else if (input[i] == '>')
                {
                    detonate += int.Parse(input[i + 1].ToString());
                }
            }

            Console.WriteLine(input);
        }
    }
}
