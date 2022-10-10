using System;
using System.Linq;

namespace _05.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            

            for (int i = 0; i < array.Length; i++)
            {

                bool isTopInteger = true;

                for (int k = i + 1; k < array.Length; k++)
                {
                    if (array[i] <= array[k])
                    {
                        isTopInteger = false;
                        break;
                    }                   
                }

                if (isTopInteger)
                {
                    Console.Write(array[i] + " ");
                }

            }
        }
    }
}
