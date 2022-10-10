using System;
using System.Linq;

namespace _04.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int rotations = int.Parse(Console.ReadLine());           

            for (int i = 0; i < rotations; i++)
            {
                int firstIndexNumber = array[0];

                for (int k = 0; k < array.Length - 1; k++)
                {
                    array[k] = array[k + 1];
                }

                array[array.Length - 1] = firstIndexNumber;
            }
            
            Console.WriteLine(String.Join(" ", array));
        }
    }
}
