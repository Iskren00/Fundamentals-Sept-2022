using System;

namespace _01.IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            long firstStep = (long)num1 + num2;
            long secondStep = firstStep / num3;
            long finalStep = secondStep * num4;
            Console.WriteLine(finalStep);
        }
    }
}
