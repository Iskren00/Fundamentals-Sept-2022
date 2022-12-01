using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.DestinationMapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\=|\/)(?<destination>[A-Z][A-Za-z]{2,})\1";

            Regex regex = new Regex(pattern);

            var destinations = new List<string>();

            string input = Console.ReadLine();

            MatchCollection matches = regex.Matches(input);

            int travelPoints = 0;

            foreach  (Match match in matches)
            {
                string currDestination = match.Groups["destination"].Value;
                destinations.Add(currDestination);
                travelPoints += currDestination.Length;
            }

            Console.Write("Destinations: ");
            Console.Write(String.Join(", ", destinations));
            Console.WriteLine();
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
