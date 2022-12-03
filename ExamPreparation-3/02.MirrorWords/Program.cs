using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.MirrorWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(\@|\#)(?<word>[A-Za-z]{3,})\1\1(?<reverseWord>[A-Za-z]{3,})\1";

            Regex regex = new Regex(pattern);

            MatchCollection collection = regex.Matches(input);

            List<string> list = new List<string>();

            if (collection.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else if (collection.Count > 0)
            {
                Console.WriteLine($"{collection.Count} word pairs found!");
            }

            foreach (Match match in collection)
            {
                string word = match.Groups["word"].Value;
                string reverse = match.Groups["reverseWord"].Value;

                reverse = Reverse(reverse);

                if (word == reverse)
                {
                    list.Add($"{word} <=> {match.Groups["reverseWord"].Value}");
                }
            }

            if (list.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else if (list.Count > 0)
            {
                Console.WriteLine("The mirror words are:");
                Console.Write(String.Join(", ", list));
                
            }


        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
