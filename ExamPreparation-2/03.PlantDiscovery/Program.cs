using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PlantDiscovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> plantRarity = new Dictionary<string, int>();
            Dictionary<string, List<double>> plantRating = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string[] plantInfo = input
                    .Split("<->", StringSplitOptions.RemoveEmptyEntries);

                string name = plantInfo[0];
                int rarity = int.Parse(plantInfo[1]);

                if (!plantRarity.ContainsKey(name))
                {
                    plantRarity.Add(name, rarity);
                    plantRating.Add(name, new List<double>());
                }
                else
                {
                    plantRarity[name] = rarity;
                }
            }

            string commant;

            char[] separator = { ':', '-', ' ' };

            while ((commant = Console.ReadLine()) != "Exhibition")
            {
                string[] cmdArg = commant
                    .Split(separator, StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArg[0];
                string plant = cmdArg[1];

                if (cmdType == "Rate")
                {
                    double rating = double.Parse(cmdArg[2]);
                    if (plantRating.ContainsKey(plant))
                    {
                        plantRating[plant].Add(rating);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (cmdType == "Update")
                {
                    int newRarity = int.Parse(cmdArg[2]);

                    if (plantRating.ContainsKey(plant))
                    {
                        plantRarity[plant] = newRarity;
                    }
                    else 
                        {
                        Console.WriteLine("error");
                    }                 
                }
                else if (cmdType == "Reset")
                {
                    if (plantRating.ContainsKey(plant))
                    {
                        plantRating[plant].Clear();
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }        
                }               
            }
            Console.WriteLine("Plants for the exhibition:");

            foreach (var (plantName, rarity) in plantRarity)
            {
                if (plantRating[plantName].Count > 0)
                {
                    double average = plantRating[plantName].Average();
                    Console.WriteLine($"- {plantName}; Rarity: {rarity}; Rating: {average:F2}");
                }
                else
                {
                    Console.WriteLine($"- {plantName}; Rarity: {rarity}; Rating: {0:F2}");
                }  
            }
        }
    }
}
