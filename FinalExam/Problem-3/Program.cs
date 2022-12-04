using System;
using System.Collections.Generic;

namespace Problem_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> likes = new Dictionary<string, int>();
            Dictionary<string, int> comments = new Dictionary<string, int>();

            string command;

            while ((command = Console.ReadLine()) != "Log out")
            {
                string[] cmdArg = command
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArg[0];
                string username = cmdArg[1];

                if (cmdType == "New follower")
                {
                    if (likes.ContainsKey(username))
                    {
                        continue;
                    }

                    likes.Add(username, 0);
                    comments.Add(username, 0);
                }
                else if (cmdType == "Like")
                {
                    int countOfLikes = int.Parse(cmdArg[2]);

                    if (!likes.ContainsKey(username))
                    {
                        likes.Add(username, countOfLikes);
                        comments.Add(username, 0);
                    }
                    else
                    {
                        likes[username] += countOfLikes;
                    }
                }
                else if(cmdType == "Comment")
                {
                    if (!comments.ContainsKey(username))
                    {
                        comments.Add(username, 1);
                        likes.Add(username, 0);
                    }
                    else
                    {
                        comments[username] += 1;
                    }
                }
                else if (cmdType == "Blocked")
                {
                    if (!likes.ContainsKey(username))
                    {
                        Console.WriteLine($"{username} doesn't exist.");
                    }
                    else
                    {
                        likes.Remove(username);
                        comments.Remove(username);
                    }
                }
            }

            Console.WriteLine($"{likes.Count} followers");

            foreach (var (username, like) in likes)
            {
                Console.WriteLine($"{username}: {like + comments[username]}");
            }
        }
    }
}
