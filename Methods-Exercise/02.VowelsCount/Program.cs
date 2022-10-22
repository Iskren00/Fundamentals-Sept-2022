using System;

namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int vowelsCount = VowelsCount(text);

            Console.WriteLine(vowelsCount);
        }

        static int VowelsCount(string text)
        {
            int counter = 0;

            foreach (char letter in text.ToLower())
            {
                if (letter == 'a' || letter == 'e' || letter == 'o' || letter == 'u' || letter == 'i' || letter == 'y')
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
