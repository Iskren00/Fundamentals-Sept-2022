using System;
using System.Collections.Generic;

namespace _05.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string courseInfo;

            while ((courseInfo = Console.ReadLine()) != "end")
            {
                string[] input = courseInfo
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                string courseName = input[0];
                string studentName = input[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses[courseName] = new List<string>();
                }

                courses[courseName].Add(studentName);
            }

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");

                foreach (var item in course.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
