using System;
using System.Diagnostics;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double totalPrice = 0;
            double discount = 0;
            double priceForOne = 0;

            switch (type)
            {
                case "Students":
                    if (day == "Friday")
                    {
                        priceForOne = 8.45;
                    }
                    else if (day == "Saturday")
                    {
                        priceForOne = 9.80;
                    }
                    else if (day == "Sunday")
                    {
                        priceForOne = 10.46;
                    }

                    break;
                case "Business":
                    if (day == "Friday")
                    {
                        priceForOne = 10.90;
                    }
                    else if (day == "Saturday")
                    {
                        priceForOne = 15.60;
                    }
                    else if (day == "Sunday")
                    {
                        priceForOne = 16;
                    }

                    break;
                case "Regular":
                    if (day == "Friday")
                    {
                        priceForOne = 15;
                    }
                    else if (day == "Saturday")
                    {
                        priceForOne = 20;
                    }
                    else if (day == "Sunday")
                    {
                        priceForOne = 22.50;
                    }

                    break;
            }

            totalPrice = priceForOne * counter;

            if (type == "Students" && counter >= 30)
            {
                discount = totalPrice * 0.15;
            }
           else if (type == "Business" && counter >= 100)
            {
                totalPrice = priceForOne * (counter - 10);
            }
           else if (type == "Regular" && counter >= 10 && counter <= 20)
            {
                discount = totalPrice * 0.05;
            }

            totalPrice -= discount;

            Console.WriteLine($"Total price: {totalPrice:f2}");


        }
    }
}
