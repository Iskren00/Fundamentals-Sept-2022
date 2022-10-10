using System;
using System.Linq;

namespace _08.MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int magicSum = int.Parse(Console.ReadLine());

            

            for (int i = 0; i < numbers.Length; i++)
            {
                int sum = 0;

                for (int j = i +1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == magicSum)
                    {
                        Console.Write(numbers[i] + " " + numbers[j]);

                        sum = numbers[i] + numbers[j];
                    }
                }

                if (sum == magicSum)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
