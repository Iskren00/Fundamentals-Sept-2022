using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double totalPrice = 0;

            for (int i = 1; i <= n; i++)
            {
                double price = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCnt = int.Parse(Console.ReadLine());

                double sumPrice = ((days * capsulesCnt) * price);

                Console.WriteLine($"The price for the coffee is: ${sumPrice:f2}");

                totalPrice += sumPrice;

                if (i == n)
                {
                    Console.WriteLine($"Total: ${totalPrice:f2}");
                }
            }


            
        }
    }
}
