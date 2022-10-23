using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArg = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArg[0];

                if (cmdType == "Delete")
                {
                    int element = int.Parse(cmdArg[1]);

                    numbers.RemoveAll(x => x == element);
                }
                else if (cmdType == "Insert")
                {
                    int element = int.Parse(cmdArg[1]);
                    int index = int.Parse(cmdArg[2]);

                    numbers.Insert(index, element);
                }
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
