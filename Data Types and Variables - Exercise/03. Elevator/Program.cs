using System;

namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int coursesCnt = 0;

            if (numberOfPeople < capacity)
            {
                coursesCnt++;

                Console.WriteLine(coursesCnt);
                return;
            }

            int firstStep = numberOfPeople / capacity;

            coursesCnt += firstStep;

            if (numberOfPeople % capacity != 0)
            {
                int secondStep = numberOfPeople % capacity;

                coursesCnt++;
            }

            Console.WriteLine(coursesCnt);

        }
    }
}
