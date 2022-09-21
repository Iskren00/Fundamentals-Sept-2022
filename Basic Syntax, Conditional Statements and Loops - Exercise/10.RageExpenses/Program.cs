using System;
using System.Transactions;

namespace _10.RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGameCnt = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double sumHeadsetsPrice = headsetPrice * (lostGameCnt / 2);
            double sumMousesPrice = mousePrice * (lostGameCnt / 3);
            double sumKeyboardsPrice = keyboardPrice * (lostGameCnt / 6);
            double sumDisplaysPrice = displayPrice * (lostGameCnt / 12);

            double sumAll = sumHeadsetsPrice + sumMousesPrice + sumKeyboardsPrice + sumDisplaysPrice;

            Console.WriteLine($"Rage expenses: {sumAll:f2} lv.");
        }
    }
}
