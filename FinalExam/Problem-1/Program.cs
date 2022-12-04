using System;
using System.Text;

namespace Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder spell = new StringBuilder(Console.ReadLine());

            string command;

            while ((command = Console.ReadLine()) != "Abracadabra")
            {
                string[] cmdArg = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArg[0];

                if (cmdType == "Abjuration")
                {
                   string newSpell = spell.ToString().ToUpper();
                    spell.Clear();
                    spell.Append(newSpell);
                    Console.WriteLine(spell);
                }
                else if (cmdType == "Necromancy")
                {
                    string newSpell = spell.ToString().ToLower();
                    spell.Clear();
                    spell.Append(newSpell);
                    Console.WriteLine(spell);
                }
                else if (cmdType == "Illusion")
                {
                    int index = int.Parse(cmdArg[1]);
                    string letter = cmdArg[2];

                    if (index < 0 || index >= spell.Length)
                    {
                        Console.WriteLine("The spell was too weak.");
                        continue;
                    }

                    spell.Remove(index, 1);
                    spell.Insert(index, letter);
                    Console.WriteLine("Done!");
                }
                else if (cmdType == "Divination")
                {
                    string substring = cmdArg[1];
                    string replace = cmdArg[2];

                    if (!spell.ToString().Contains(substring))
                    {
                        continue;
                    }

                    spell.Replace(substring, replace);
                    Console.WriteLine(spell);
                }
                else if (cmdType == "Alteration")
                {
                    string substring = cmdArg[1];

                    if (!spell.ToString().Contains(substring))
                    {
                        continue;
                    }

                    int index = spell.ToString().IndexOf(substring[0]);

                    spell.Remove(index, substring.Length);

                    Console.WriteLine(spell);
                }
                else
                {
                    Console.WriteLine("The spell did not work!");
                }
            }
        }
    }
}
