using System;
using System.Text;

namespace _05.MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int multiply = int.Parse(Console.ReadLine());
            int reminder = 0;

            var sb = new StringBuilder();

            if (multiply == 0 || number == "0")
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = number.Length - 1; i >= 0; i--)
            {
                int currNum = int.Parse(number[i].ToString());
                int product = currNum * multiply + reminder;
                int result = product % 10;
                reminder = product / 10;
                sb.Insert(0 ,result);

            }

            if (reminder > 0)
            {
                sb.Insert(0, reminder);
            }

            Console.WriteLine(sb);
        }
    }
}
