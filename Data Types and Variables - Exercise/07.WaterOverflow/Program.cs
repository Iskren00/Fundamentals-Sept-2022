using System;
using System.Diagnostics.CodeAnalysis;

namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                sum += input;               

                if (sum > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum -= input;
                }

                if (i == n - 1)
                {
                    Console.WriteLine(sum);
                }
            }
           
        }
    }
}
