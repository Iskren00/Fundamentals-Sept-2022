using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cards = Console.ReadLine()
                .Split(", ")
                .ToList();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<string> cmdArg = Console.ReadLine()
                    .Split(", ")
                    .ToList();

                if (cmdArg[0] == "Add")
                {
                    if (cards.Contains(cmdArg[1]))
                    {
                        Console.WriteLine("Card is already in the deck");
                        continue;
                    }
                    cards.Add(cmdArg[1]);
                    Console.WriteLine("Card successfully added");
                }
                else if (cmdArg[0] == "Remove")
                {
                    if (!cards.Contains(cmdArg[1]))
                    {
                        Console.WriteLine("Card not found");
                        continue;
                    }
                    cards.Remove(cmdArg[1]);
                    Console.WriteLine("Card successfully removed");
                }
                else if (cmdArg[0] == "Remove At")
                {
                    int index = int.Parse(cmdArg[1]);

                    if (index < 0 || index >= cards.Count)
                    {
                        Console.WriteLine("Index out of range");
                    }
                    else
                    {
                        cards.RemoveAt(index);
                        Console.WriteLine("Card successfully removed");
                    }
                }
                else if (cmdArg[0] == "Insert")
                {
                    int index = int.Parse(cmdArg[1]);
                    string cardName = cmdArg[2];

                    if (index < 0 || index >= cards.Count)
                    {
                            Console.WriteLine("Index out of range");
                            continue;               
                    }
                    else if (index >= 0 || index < cards.Count)
                    {
                        if (cards.Contains(cardName))
                        {
                            Console.WriteLine("Card is already added");
                            continue;
                        }

                        cards.Insert(index, cardName);
                        Console.WriteLine("Card successfully added");
                    }
                }

            }

            Console.Write(String.Join(", ", cards));
        }
    }
}
