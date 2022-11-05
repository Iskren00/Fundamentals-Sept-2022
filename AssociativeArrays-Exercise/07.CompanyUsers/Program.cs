using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _07.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            Dictionary<string, List<string>> companyUsers = new Dictionary<string, List<string>>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] companyInfo = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string companyName = companyInfo[0];
                string empoyeedId = companyInfo[1];

                if (!companyUsers.ContainsKey(companyName))
                {
                    companyUsers[companyName] = new List<string>();
                }

                if (!companyUsers[companyName].Contains(empoyeedId))
                {
                    companyUsers[companyName].Add(empoyeedId);
                }
            }

            foreach (var companys in companyUsers)
            {
                Console.WriteLine(companys.Key);

                foreach (var item in companys.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
