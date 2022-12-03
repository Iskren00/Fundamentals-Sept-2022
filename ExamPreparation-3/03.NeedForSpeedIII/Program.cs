using System;
using System.Collections.Generic;

namespace _03.NeedForSpeedIII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> carMileage = new Dictionary<string, int>();
            Dictionary<string, int> carFuel = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string[] carsInfo = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);

                string car = carsInfo[0];
                int mileage = int.Parse(carsInfo[1]);
                int fuel = int.Parse(carsInfo[2]);

                carMileage.Add(car, mileage);
                carFuel.Add(car, fuel);
            }

            string command;

            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] cmdArg = command
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArg[0];
                string car = cmdArg[1];

                if (cmdType == "Drive")
                {
                    int distance = int.Parse(cmdArg[2]);
                    int fuel = int.Parse(cmdArg[3]);

                    if (fuel > carFuel[car])
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        carMileage[car] += distance;
                        carFuel[car] -= fuel;

                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                    }

                    if (carMileage[car] >= 100000)
                    {
                        carMileage.Remove(car);
                        Console.WriteLine($"Time to sell the {car}!");
                    }
                }
                else if (cmdType == "Refuel")
                {
                    int fuel = int.Parse(cmdArg[2]);

                    if (carFuel[car] + fuel > 75)
                    {
                        fuel = 75 - carFuel[car];
                    }

                    carFuel[car] += fuel;

                    Console.WriteLine($"{car} refueled with {fuel} liters");
                }
                else if (cmdType == "Revert")
                {
                    int kilometers = int.Parse(cmdArg[2]);

                    if (carMileage[car] - kilometers < 10000)
                    {
                        carMileage[car] = 10000;
                        break;
                    }

                    carMileage[car] -= kilometers;

                    Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                }
            }

            foreach (var car in carMileage)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value} kms, Fuel in the tank: {carFuel[car.Key]} lt.");
            }
        }
    }
}
