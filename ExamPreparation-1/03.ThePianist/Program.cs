using System;
using System.Collections.Generic;

namespace _03.ThePianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> pieces = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string[] piece = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);

                string name = piece[0];
                string composer = piece[1];
                string key = piece[2];

                pieces.Add(name, new List<string>());
                pieces[name].Add(composer);
                pieces[name].Add(key);
            }

            string command;

            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] cmdArg = command
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArg[0];
                string piece = cmdArg[1];

                if (cmdType == "Add")
                {
                    string composer = cmdArg[2];
                    string key = cmdArg[3];

                    if (!pieces.ContainsKey(piece))
                    {
                        pieces.Add(piece, new List<string>());
                        pieces[piece].Add(composer);
                        pieces[piece].Add(key);
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                }
                else if(cmdType == "Remove")
                {
                    if (pieces.ContainsKey(piece))
                    {
                        pieces.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                } 
                else if (cmdType == "ChangeKey")
                {
                    string newKey = cmdArg[2];
                    if (pieces.ContainsKey(piece))
                    {
                        pieces[piece].RemoveAt(1);
                        pieces[piece].Add(newKey);
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }                   
                }
            }

            foreach (var piece in pieces)
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value[0]}, Key: {piece.Value[1]}");
            }
        }
    }
}
