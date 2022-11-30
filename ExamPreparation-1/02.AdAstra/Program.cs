using System;
using System.Text.RegularExpressions;

namespace _02.AdAstra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([\#|\|]{1})(?<itemName>[A-Za-z ]+)\1(?<date>[\d/\d/d]{8})\1(?<calories>\d+)\1";

            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();

            int sumOfCalories = 0;

            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                int calories = int.Parse(match.Groups["calories"].Value);

                sumOfCalories += calories;
            }

            int days = sumOfCalories / 2000;

            Console.WriteLine($"You have food to last you for: {days} days!");
            foreach (Match match in matches)
            {
                Console.WriteLine($"Item: {match.Groups["itemName"].Value}, Best before: {match.Groups["date"].Value}, Nutrition: {match.Groups["calories"].Value}");
            }
        }
    }
}
