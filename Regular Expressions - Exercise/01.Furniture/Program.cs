using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01.Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patrern = @"^>>(?<name>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)(\.\d+)?$";
            Regex regex = new Regex(patrern);

            List<string> boughtFurnitures = new List<string>();
            double totalSum = 0;

            string input;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match match = regex.Match(input);

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    double priceForOne = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    boughtFurnitures.Add(name);
                    totalSum += priceForOne * quantity;
                }
            }

            Console.WriteLine("Bought furniture:");
            foreach (var furniture in boughtFurnitures)
            {
                Console.WriteLine(furniture);
            }
            Console.WriteLine($"Total money spend: {totalSum:F2}");
        }
    }
}
