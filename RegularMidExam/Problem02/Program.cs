using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem02
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

            while ((command = Console.ReadLine()) != "Finish")
            {
                string[] cmdArg = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArg[0];
                int value = int.Parse(cmdArg[1]);

                if (cmdType == "Add")
                {
                    numbers.Add(value);
                }
                else if (cmdType == "Remove")
                {
                    numbers.Remove(value);
                }
                else if (cmdType == "Replace")
                {
                    int replaceValue = int.Parse(cmdArg[2]);
                    int currIndex = 0;

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == value)
                        {
                            currIndex = i;
                            numbers.RemoveAt(i);
                            numbers.Insert(currIndex, replaceValue);
                            break;
                        }
                    }
                }
                else if (cmdType == "Collapse")
                {
                    numbers.RemoveAll(x => x < value);
                }
                    
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
