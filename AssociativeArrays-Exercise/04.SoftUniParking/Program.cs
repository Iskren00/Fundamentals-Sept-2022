using System;
using System.Collections.Generic;

namespace _04.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> register =
                new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] cmdArg = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArg[0];
                string username = cmdArg[1];

                if (cmdType == "register")
                {
                    string license = cmdArg[2];

                    if (register.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {register[username]}");
                    }
                    else
                    {
                        register[username] = license;
                        Console.WriteLine($"{username} registered {license} successfully");
                    }
                }
                else if (cmdType == "unregister")
                {
                    if (!register.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        register.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }              
            }

            foreach (var item in register)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
