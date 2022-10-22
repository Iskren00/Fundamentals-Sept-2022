using System;

namespace _01.SmallestОfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());


            int smallestNumber = SmallestNumber(numberOne, numberTwo, numberThree);

            Console.WriteLine(smallestNumber);
        }


        static int SmallestNumber(int numberOne, int numberTwo, int numberThree)
        {
            int smallestNumber = 0;

            if (numberOne <= numberTwo && numberOne <= numberThree)
            {
                 smallestNumber = numberOne;
            }
            else if (numberTwo <= numberOne && numberTwo <= numberThree)
            {
                 smallestNumber = numberTwo;
            }
            else  if (numberThree <= numberOne && numberThree <= numberTwo)
            {
                 smallestNumber = numberThree;
            }

            return smallestNumber;
        }
    }
}
