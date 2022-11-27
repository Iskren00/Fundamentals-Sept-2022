using System;
using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^[^\|\$\%\.]*\%(?<name>[A-Z][a-z]+)\%[^\|\$\%\.]*?<(?<product>\w+)>[^\|\$\%\.]*?\|(?<count>\d+)\|[^\|\$\%\.]*?(?<price>\d+(\.\d+)?)\$[^\|\$\%\.]*?$";
            string input = string.Empty;

            Regex regex = new Regex(pattern);
            double totalIncome = 0;

            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match match = regex.Match(input);

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);

                    totalIncome += count * price;

                    Console.WriteLine($"{name}: {product} - {count * price:f2}");
                }
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
