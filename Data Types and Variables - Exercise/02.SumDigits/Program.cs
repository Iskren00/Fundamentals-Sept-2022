using System;

namespace _02.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int numberCopy = number;

            int currentNumber = 0;
            int sum = 0;
                
            while (numberCopy > 0)
            {
                currentNumber = numberCopy % 10;

                sum += currentNumber;

                numberCopy /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}
