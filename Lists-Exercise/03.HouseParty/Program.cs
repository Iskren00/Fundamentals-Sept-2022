using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The count of people, that will follow.
            int count = int.Parse(Console.ReadLine());

            //Make a list for people, who will going to the party.
            List<string> people = new List<string>();

            for (int i = 0; i < count; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries);

                string name = command[0];

                if (command.Count() == 3)
                {
                    if (people.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                        continue;
                    }

                    people.Add(name);
                }
                else if (command.Count() == 4)
                {

                    if (!people.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                        continue;
                    }

                    people.Remove(name);
                }
            }
            //Print the end result.
            Console.WriteLine(String.Join("\r\n", people));
        }
    }
}
