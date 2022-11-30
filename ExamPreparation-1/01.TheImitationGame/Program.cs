using System;
using System.Reflection;
using System.Text;

namespace _01.TheImitationGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
              StringBuilder encryptedMessage = new StringBuilder(Console.ReadLine());

            string command;
            while ((command = Console.ReadLine()) != "Decode")
            {
                string[] cmdArg = command.Split('|', StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArg[0];

                if (cmdType == "Move")
                {
                    int numberOfLetter = int.Parse(cmdArg[1]);
                    string copy = string.Empty;

                    for (int i = 0; i < numberOfLetter; i++)
                    {
                        copy += encryptedMessage[i];
                    }

                    encryptedMessage.Remove(0, numberOfLetter);
                    encryptedMessage.Append(copy);
                }
                else if (cmdType == "Insert")
                {
                    int index = int.Parse(cmdArg[1]);
                    string value = cmdArg[2];

                    encryptedMessage.Insert(index, value);
                }
                else if (cmdType == "ChangeAll")
                {
                    string substring = cmdArg[1];
                    string relacement = cmdArg[2];

                    encryptedMessage.Replace(substring, relacement);
                }
            }

            Console.WriteLine($"The decrypted message is: {encryptedMessage}");
        }
    }
}
