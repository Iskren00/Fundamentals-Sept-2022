using System;

namespace _02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            GetTheSum(input[0], input[1]);
        }

        static void GetTheSum(string word1, string word2)
        {
            int sum = 0;

            int minLenght = Math.Min(word1.Length, word2.Length);

            for (int i = 0; i < minLenght; i++)
            {
                sum += word1[i] * word2[i];
            }

            string longString = word1;
            if (longString.Length < word2.Length)
            {
                longString = word2;
            }

            for (int i = minLenght; i < longString.Length; i++)
            {
                sum += longString[i];
            }

            Console.WriteLine(sum);
        }
    }
}
