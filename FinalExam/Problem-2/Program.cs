using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string pattern = @"^(.+)>(?<numbers>\d{3,})\|(?<lower>[a-z]{3,})\|(?<upper>[A-Z]{3,})\|(?<symbols>.+[^\<\""\>])<\1$";

            Regex regex = new Regex(pattern);

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match match = regex.Match(input);

                if (match.Success)
                {
                    StringBuilder encrypt = new StringBuilder();

                    encrypt.Append(match.Groups["numbers"].Value);
                    encrypt.Append(match.Groups["lower"].Value);
                    encrypt.Append(match.Groups["upper"].Value);
                    encrypt.Append(match.Groups["symbols"].Value);
                    Console.WriteLine($"Password: {encrypt}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
