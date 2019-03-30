using System;

namespace Methods_Exercise___09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string reversedInput = String.Empty;

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reversedInput += input[i];
                }



                if (input == reversedInput)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }

        static bool PalindromeChecker(string input, string reversedInput)
        {
            if (input == reversedInput)
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
