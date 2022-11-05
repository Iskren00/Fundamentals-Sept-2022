using System;
using System.Collections.Generic;

namespace _03.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> orders = new Dictionary<string, double>();
            Dictionary<string, int> currentQuantity = new Dictionary<string, int>();

            string cmdArg;
            //"{name} {price} {quantity}"
            while ((cmdArg = Console.ReadLine()) != "buy")
            {
                string[] input = cmdArg.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                double price = double.Parse(input[1]);
                int quantity = int.Parse(input[2]);


                if (!currentQuantity.ContainsKey(name))
                {
                    currentQuantity[name] = quantity;
                }
                else if (currentQuantity.ContainsKey(name))
                {
                    currentQuantity[name] += quantity;
                }

                if (!orders.ContainsKey(name))
                {
                    orders[name] = price * quantity;                  
                }
                else
                {  
                    orders[name] = price * currentQuantity[name];
                }
            }

            foreach (var item in orders)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:F2}");
            }
        }
    }
}
