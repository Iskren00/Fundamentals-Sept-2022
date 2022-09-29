using System;

namespace _09.SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int days = 0;
            int leaving = 0;
          
            while (startingYield >= 100)
            {
                days++;
                leaving += startingYield;
                leaving -= 26;
                startingYield -= 10;
            }

            if (leaving >= 26)
            {
                leaving -= 26;
            }
        

            Console.WriteLine(days);
            Console.WriteLine(leaving);

        }
    }
}
