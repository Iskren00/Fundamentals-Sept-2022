using System;

namespace _05.AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());
            
            int sum = SumOfFirstAndSecondNumber(numOne, numTwo);

            int subtract = SubtractOfSumAndThirdNumber(sum, numThree);

            Console.WriteLine(subtract);
        }

        static int SumOfFirstAndSecondNumber(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;

            return sum;
        }

        static int SubtractOfSumAndThirdNumber(int sum, int thirdNumber)
        {
            int subtract = sum - thirdNumber;

            return subtract;
        }
    }
}
