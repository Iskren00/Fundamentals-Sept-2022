using System;
using System.Numerics;
using System.Xml.Schema;

namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double volume = double.MinValue;

            string biggerKeg = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                uint height = uint.Parse(Console.ReadLine());

                //π * r^2 * h. 

                double formula = Math.Pow(radius, 2) * height;
                formula = Math.PI * formula;

                if (formula > volume)
                {
                    volume = formula;
                    biggerKeg = model;
                }

                if (i == n - 1)
                {
                    Console.WriteLine(biggerKeg);
                }

                formula = 0;
            }

            
        }
    }
}
