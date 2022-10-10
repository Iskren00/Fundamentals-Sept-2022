using System;

namespace _02.CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine()
                    .Split(" ");

            string[] secondArray = Console.ReadLine()
                .Split(" ");

            for (int i = 0; i < secondArray.Length; i++)
            {

                for (int k = 0; k < firstArray.Length; k++)
                {
                    if (secondArray[i] == firstArray[k])
                    {
                        Console.Write(secondArray[i] + " ");
                    }
                }

            }
        }
    }
}
