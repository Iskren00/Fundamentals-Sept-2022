using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> racers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Dictionary<string, int> people = new Dictionary<string, int>();

            string input;

            while ((input = Console.ReadLine()) != "end of race")
            {  
                int distance = 0;
                string name = string.Empty;
                StringBuilder sb = new StringBuilder();

                foreach (char ch in input)
                {
                    if (char.IsDigit(ch))
                    {
                        distance += ch - 48;
                    }
                    else if (char.IsLetter(ch))
                    {
                        sb.Append(ch);
                    }
                }

                name = sb.ToString();

                if (racers.Contains(name))
                {
                    if (!people.ContainsKey(name))
                    {
                        people[name] = 0;
                    }

                    people[name] += distance;
                }
            }

            int counter = 0;

            foreach (var person in people.OrderByDescending(km => km.Value))
            {
                counter++;
                if (counter == 1)
                {
                    Console.WriteLine($"1st place: {person.Key}");
                }
                else if (counter == 2)
                {
                    Console.WriteLine($"2nd place: {person.Key}");
                }
                else if (counter == 3)
                {
                    Console.WriteLine($"3rd place: {person.Key}");
                    break;
                }
            }
        }
    }
}
