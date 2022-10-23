using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numberOfPassengers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string command = string.Empty;
            
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArg = command
                    .Split(' ');
                
                if (cmdArg.Count() == 2)
                {
                    int givenPassengers = int.Parse(cmdArg[1]);

                    numberOfPassengers.Add(givenPassengers);
                }
                else if (cmdArg.Count() == 1)
                {
                    int fitThePassengers = int.Parse(cmdArg[0]);

                    for (int i = 0; i < numberOfPassengers.Count; i++)
                    {
                        if (numberOfPassengers[i] + fitThePassengers <= maxCapacity)
                        {
                            numberOfPassengers[i] += fitThePassengers;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(String.Join(" ", numberOfPassengers));
        }
    }
}
