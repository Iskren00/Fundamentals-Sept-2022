using System;
using System.Collections.Generic;

namespace _01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            var num = new Dictionary<char, int>();

            foreach (var ch in word)
            {
                if (ch != ' ')
                {
                    if (!num.ContainsKey(ch))
                    {
                        num.Add(ch, 0);
                    }
                    num[ch]++;
                }
            }

            foreach (var item in num)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");               
            }
        }
    }
}
