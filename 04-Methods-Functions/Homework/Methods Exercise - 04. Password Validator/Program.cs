using System;

namespace Methods_Exercise___04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isBettween6and10 = true;
            bool isOnlyLettersAndDigits = true;
            bool haveAtleast2Digits = true;

            IsBettween6And10Chars(password, isBettween6and10);
            IsOnlyLettersAndDigits(password, isOnlyLettersAndDigits);
            HaveAtleast2Digits(password, haveAtleast2Digits);

            if (isBettween6and10 && isOnlyLettersAndDigits && haveAtleast2Digits)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static void IsOnlyLettersAndDigits(string password, bool isOnlyLetterAndDigits)
        {
            for (int i = 0; i < password.Length; i++)
            {
                char currentChar = password[i];

                if (!char.IsLetter(currentChar) && !char.IsDigit(currentChar))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    isOnlyLetterAndDigits = false;
                    break;
                }
            }
        }

        static void HaveAtleast2Digits(string password, bool haveAtleast2Digits)
        {
            int digits = 0;

            for (int i = 0; i < password.Length; i++)
            {
                char currentChar = password[i];

                if (char.IsDigit(currentChar))
                {
                    digits++;
                }
                
            }

            if (digits <= 2)
            {
                Console.WriteLine("Password must have atleast 2 digits");
                haveAtleast2Digits = false;
            }
        }

        private static void IsBettween6And10Chars(string password,bool IsBettween6And10Chars)
        {
            

            if (password.Length < 6 && password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                IsBettween6And10Chars = false;
            }
        }
    }
}
