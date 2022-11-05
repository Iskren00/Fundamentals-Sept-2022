using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentsGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentsGrades.ContainsKey(name))
                {
                    studentsGrades[name] = new List<double>();
                }

                studentsGrades[name].Add(grade);
            }

            double average = 0;

            foreach (var student in studentsGrades)
            {
                if (student.Value.Count > 1)
                {
                    average = student.Value.Average();
                }
                else
                {
                    average = student.Value[0];
                }

                if (average >= 4.50)
                {
                    Console.WriteLine($"{student.Key} -> {average:f2}");
                }
            }
        }
    }
}
