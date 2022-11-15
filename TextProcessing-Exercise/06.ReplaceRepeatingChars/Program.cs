using System;

namespace _06.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char lastLetter = ' ';

            for (int i = 0; i < input.Length; i++)
            {
                
                if (i == input.Length - 1)
                {
                    if (lastLetter == input[input.Length - 1])
                    {
                        Console.Write(lastLetter);
                    }
                    else
                    {
                        Console.WriteLine(input[i]);
                    }

                    return;
                }

                if (!(input[i] == input[i + 1]))
                {
                    Console.Write(input[i]);
                }

                lastLetter = input[i];
            }
        }
    }
}
