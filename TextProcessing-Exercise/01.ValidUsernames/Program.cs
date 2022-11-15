using System;

namespace _01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                .Split(", ");


            foreach (string currUsername in usernames)
            {
                if (currUsername.Length > 3 && currUsername.Length <= 16)
                {
                    bool isUsernameValid = true;

                    foreach (char currChar in currUsername)
                    {
                        if (!(char.IsLetterOrDigit(currChar) || currChar == '-' || currChar == '_'))
                        {
                            isUsernameValid = false;
                            break;
                        }
                    }
                    if (isUsernameValid)
                    {
                        Console.WriteLine(currUsername);
                    }
                }
            }
        }
    }
}
