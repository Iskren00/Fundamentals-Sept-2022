using System;

namespace _03.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fileInfo = Console.ReadLine()
                .Split(new char[] { 'C', ':', '.', '\\' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine($"File name: {fileInfo[fileInfo.Length - 2]}");
            Console.WriteLine($"File extension: {fileInfo[fileInfo.Length - 1]}");
        }
    }
}
