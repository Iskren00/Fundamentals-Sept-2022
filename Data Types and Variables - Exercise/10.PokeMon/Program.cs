using System;

namespace _10.PokeMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            short y = short.Parse(Console.ReadLine());

            int pokeCounter = 0;
            int copyOfN = 0;

            if (n % 2 == 0)
            {
                copyOfN = n / 2;
            }

            while (n >= m)
            {

                if (n == copyOfN && y != 0)
                {
                    n = n / y;
                }

                if (n >= m)
                {
                    n = n - m;
                    pokeCounter++;
                }
            }

            Console.WriteLine(n);
            Console.WriteLine(pokeCounter);
        }
    }
}
