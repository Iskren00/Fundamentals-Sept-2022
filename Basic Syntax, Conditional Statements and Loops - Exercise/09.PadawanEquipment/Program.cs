using System;

namespace _09.PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int studentsCnt = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double percent = studentsCnt * 0.1;
            
            double sumLightsabersPrice = lightsaberPrice * (studentsCnt + Math.Ceiling(percent));
            double sumRobesPrice = robePrice * studentsCnt;
            double sumBeltsPrice = 0;

            for (int i = 1; i <= studentsCnt; i++)
            {
                if (i % 6 != 0)
                {
                    sumBeltsPrice += beltPrice;
                }

                
            }

            double sumAll = sumLightsabersPrice + sumRobesPrice + sumBeltsPrice;

            if (sumAll <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {sumAll:f2}lv.");
            }
            else
            {
                Console.WriteLine($" John will need {sumAll - money:f2}lv more.");
            }

        }
    }
}
