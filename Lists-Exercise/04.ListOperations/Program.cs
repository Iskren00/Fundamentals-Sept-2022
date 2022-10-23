using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List of integers.
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                //Read the command type to know what to do.
                string[] cmdArg = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArg[0];

                if (cmdType == "Add")
                {
                    int number = int.Parse(cmdArg[1]);

                    numbers.Add(number);       
                }
                else if (cmdType == "Insert")
                {
                    int number = int.Parse(cmdArg[1]);
                    int index = int.Parse(cmdArg[2]);

                    if (index < 0 || index >= numbers.Count())
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.Insert(index, number);
                }
                else if (cmdType == "Remove")
                {
                    int index = int.Parse(cmdArg[1]);

                    if (index < 0 || index >= numbers.Count())
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.RemoveAt(index);
                }
                else if (cmdType == "Shift")
                {
                    string direction = cmdArg[1];
                    int count = int.Parse(cmdArg[2]);

                    if(direction == "left")
                    {                  
                        for (int i = 0; i < count; i++)
                        {
                            int firstNumber = numbers[0];

                            numbers.RemoveAt(0);
                            numbers.Add(firstNumber);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int lastNumber = numbers[numbers.Count() - 1];

                            numbers.RemoveAt(numbers.Count() - 1);
                            numbers.Insert(0, lastNumber);
                        }
                    }
                }

            }

            Console.WriteLine(String.Join(" ", numbers));

        }
    }
}
