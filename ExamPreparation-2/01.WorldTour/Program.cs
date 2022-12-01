using System;
using System.Globalization;
using System.Text;
namespace _01.WorldTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stops = new StringBuilder(Console.ReadLine());

            string command;
            while ((command = Console.ReadLine()) != "Travel")
            {
                string[] cmdArg = command
                    .Split(':', StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArg[0];

                if (cmdType == "Add Stop")
                {
                    int index = int.Parse(cmdArg[1]);
                    string newStop = cmdArg[2];

                    if (index >= 0 && index < stops.Length)
                    {
                        stops.Insert(index, newStop);
                    }
                    Console.WriteLine(stops);
                }
                else if (cmdType == "Remove Stop")
                {
                    int startIndex = int.Parse(cmdArg[1]);
                    int endIndex = int.Parse(cmdArg[2]);

                    if (startIndex >= 0 && startIndex < stops.Length && endIndex < stops.Length)
                    {
                        stops.Remove(startIndex, endIndex - startIndex + 1);
                    }
                    Console.WriteLine(stops);
                }
                else if (cmdType == "Switch")
                {
                    string oldString = cmdArg[1];
                    string newString = cmdArg[2];

                    if (stops.ToString().Contains(oldString))
                    {
                        stops.Replace(oldString, newString);
                    }
                    Console.WriteLine(stops);
                }                   
                
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}
