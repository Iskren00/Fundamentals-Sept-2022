using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] bombInf = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int numberToDetonate = bombInf[0];
            int detonationPower = bombInf[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == numberToDetonate)
                {
                    int count = 0;
                    for (int j = i - detonationPower ; j <= i + detonationPower; j++)
                    {
                       if(j < 0 || j >= numbers.Count)
                        {
                            continue;
                        }
                        numbers[j] = 0;
                    }
                }
            }
            
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}
