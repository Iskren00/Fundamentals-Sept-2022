using System;
using System.Linq;
using System.Text;

namespace _01.SecretChat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command;

            while ((command = Console.ReadLine()) != "Reveal")
            {
                string[] cmdArg = command
                    .Split(":|:", StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArg[0];

                if (cmdType == "InsertSpace")
                {
                    int index = int.Parse(cmdArg[1]);

                    input = input.Insert(index, " ");

                    Console.WriteLine(input);
                }
                else if (cmdType == "Reverse")
                {
                    string substring = cmdArg[1];

                    if (input.Contains(substring))
                    {
                        int index = input.IndexOf(substring);

                        input = input.Remove(index, substring.Length);

                        substring = Reverse(substring);

                        input += substring;

                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (cmdType == "ChangeAll")
                {
                    string substring = cmdArg[1];
                    string replacement = cmdArg[2];

                    input = input.Replace(substring, replacement);

                    Console.WriteLine(input);
                }
            }

            Console.WriteLine($"You have a new text message: {input}");
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
