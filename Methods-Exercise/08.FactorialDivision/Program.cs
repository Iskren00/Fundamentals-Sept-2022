using System;
using System.Numerics;

namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            double firstFactorial = FactorialOfNumber(firstNumber);
            double secondFactorial = FactorialOfNumber(secondNumber);

            double result = firstFactorial / secondFactorial;

            Console.WriteLine($"{result:f2}");           
        }

        static double FactorialOfNumber(int num)
        {
            double result = num;

            if (num == 0 || num == 1)
            {
                result = 1;
                return result;
            }

            while (num > 0)
            {
                for (int i = num - 1; i > 0; i--)
                {
                    result *= i;
                }

                num = 0;
            }

            return result;
        }
    }
}
