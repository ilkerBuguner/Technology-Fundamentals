using System;

namespace Methods_Exercise___04_Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isBetween6And10Chars = StringLengthChecker(password);
            bool isOnlyLetterAndDigit = StringCharsChecker(password);
            bool haveAtLeast2Digits = DigitsChecker(password);

            if (isBetween6And10Chars == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (isOnlyLetterAndDigit == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (haveAtLeast2Digits == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isBetween6And10Chars && isOnlyLetterAndDigit & haveAtLeast2Digits)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool DigitsChecker(string password)
        {
            int digitCounter = 0;

            for (int i = 0; i < password.Length; i++)
            {
                char currentChar = password[i];
                if (char.IsDigit(currentChar))
                {
                    digitCounter++;
                }
            }

            if (digitCounter >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool StringCharsChecker(string password)
        {
            bool isntLetterOrDigit = true;
            for (int i = 0; i < password.Length; i++)
            {
                char currentChar = password[i];
                if (!char.IsLetter(currentChar) && !char.IsDigit(currentChar))
                {
                    isntLetterOrDigit = false;
                }
            }

            if (isntLetterOrDigit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool StringLengthChecker(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;

            }
        }
    }
}
