using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split("|")
                .ToList();

            List<int> remake = new List<int>();

            for (int i = input.Count - 1; i >= 0; i--)
            {
                string[] array = input[i]
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int j = 0; j < array.Length; j++)
                {
                    int currNum = int.Parse(array[j]);
                    remake.Add(currNum);
                }                  
            }

            Console.WriteLine(String.Join(" ", remake));
        }
    }
}
