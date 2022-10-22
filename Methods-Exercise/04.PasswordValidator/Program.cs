using System;

namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool lenght = PasswordLenght(password);
            bool alphaNumeric = IsPasswordAlphaNumeric(password);
            bool digits = IsContainAtLeastTwoDigits(password);

            if (!lenght)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!alphaNumeric)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!digits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (lenght && alphaNumeric && digits)
            {
                Console.WriteLine("Password is valid");
            }


        }

        static bool PasswordLenght(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }

            return false;
        }

        static bool IsPasswordAlphaNumeric(string password)
        {
            foreach (char ch in password)
            {
                if (!Char.IsLetterOrDigit(ch))
                {
                    return false;
                }
            }

            return true;
        }

        static bool IsContainAtLeastTwoDigits(string password)
        {
            int count = 0;

            foreach (char ch in password)
            {
                if (ch == '0' || ch == '1' || ch == '2' || ch == '3' || ch == '4' || ch == '5' || ch == '6' || ch == '7' || ch == '8' || ch == '9')
                {
                    count++;
                }
            }

            if (count >= 2)
            {
                return true;
            }

            return false;
        }
    }
}
