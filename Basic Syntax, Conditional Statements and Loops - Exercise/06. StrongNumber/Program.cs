using System;

namespace _06._StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int nCnt = n;

            int count = 0;

            int fact = 1;

            int sum = 0;

            while (nCnt != 0)
            {
                fact = 1;
                count = nCnt % 10;

                for (int i = 2; i <= count ; i++)
                {
                    fact *= i;
                }

                nCnt /= 10;

                sum += fact;
            }

            if (sum == n)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
