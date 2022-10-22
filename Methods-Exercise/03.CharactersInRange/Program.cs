using System;

namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            PrintAllCharecter(firstChar, secondChar);
        }

        static void PrintAllCharecter(char charOne, char charTwo)
        {
            char copy = charTwo;

            if (charTwo < charOne)
            {
                charTwo = charOne;
                charOne = copy;
            }

            for (int i = charOne + 1; i < charTwo; i++)
            {
                char currentChar = (char)i;

                Console.Write(currentChar + " ");
            }

        }
    }
}
