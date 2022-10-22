using System;
using System.Linq;
using System.Linq.Expressions;

namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                int number = int.Parse(input);

                bool isPalindrome = IsPalindromeInteger(input);


                if (isPalindrome)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                
            }
        }


        static bool IsPalindromeInteger(string numbers)
        {
            bool isPalindrome = false;

            string palindrom = string.Empty;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                palindrom += numbers[i];
            }

            if (numbers == palindrom)
            {
                isPalindrome = true;
            }

            return isPalindrome;
        }
    }
}
