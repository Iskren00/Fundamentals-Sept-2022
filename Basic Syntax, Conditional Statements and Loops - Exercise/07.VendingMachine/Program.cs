using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace _07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = 0;

            string inputMoney;
            while ((inputMoney = Console.ReadLine()) != "Start")
            {
                switch (inputMoney)
                {
                    case "0.1":
                        balance += double.Parse(inputMoney);
                        break;
                    case "0.2":
                        balance += double.Parse(inputMoney);
                        break;
                    case "0.5":
                        balance += double.Parse(inputMoney);
                        break;
                    case "1":
                        balance += double.Parse(inputMoney);
                        break;
                    case "2":
                        balance += double.Parse(inputMoney);
                        break;

                    default:
                        Console.WriteLine($"Cannot accept {inputMoney}");
                        break;
                }

            }

            string end;
            while ((end = Console.ReadLine()) != "End")
            {
                switch (end)
                {
                    case "Nuts":
                        balance -= 2.0;

                        if (balance >= 0)
                        {
                            Console.WriteLine($"Purchased nuts");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            balance += 2.0;
                        }
                        
                        break;
                    case "Water":
                        balance -= 0.7;

                        if (balance >= 0)
                        {
                            Console.WriteLine($"Purchased water");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            balance += 0.7;
                        }

                        break;
                    case "Crisps":
                        balance -= 1.5;

                        if (balance >= 0)
                        {
                            Console.WriteLine($"Purchased crisps");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            balance += 1.5;
                        }

                        break;
                    case "Soda":
                        balance -= 0.8;

                        if (balance >= 0)
                        {
                            Console.WriteLine($"Purchased soda");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            balance += 0.8;
                        }

                        break;
                    case "Coke":
                        balance -= 1.0;

                        if (balance >= 0)
                        {
                            Console.WriteLine($"Purchased coke");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            balance += 1.0;
                        }

                        break;

                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
            }

            Console.WriteLine($"Change: {balance:f2}");
        }
    }
}
