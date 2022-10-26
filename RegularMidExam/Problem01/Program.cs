using System;

namespace Problem01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            decimal flourPrice = decimal.Parse(Console.ReadLine());
            decimal eggPrice = decimal.Parse(Console.ReadLine());
            decimal apronPrice = decimal.Parse(Console.ReadLine());

            //For one student --> 1- flour, 10 eggs, an apron,
            decimal flourSum = 0;
            decimal eggsSum = 0;
            decimal apronSum = 0;

            for (int i = 1; i <= students; i++)
            {
                if (i % 5 == 0)
                {
                    continue;
                }
                flourSum += flourPrice;
            }

            eggsSum = (students * 10) * eggPrice;

            decimal numberOfApron = Math.Ceiling(students * 1.2m);

            apronSum = numberOfApron * apronPrice;

            decimal sumAll = flourSum + eggsSum + apronSum;


            if (budget >= sumAll)
            {
                Console.WriteLine($"Items purchased for {sumAll:f2}$.");
            }
            else
            {
                Console.WriteLine($"{sumAll - budget:F2}$ more needed.");
            }
        }
    }
}
