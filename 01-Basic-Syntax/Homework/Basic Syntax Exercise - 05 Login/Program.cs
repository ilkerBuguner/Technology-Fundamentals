using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Syntax_Exercise___05_Login
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            string name = Console.ReadLine();
            string reverseName = string.Empty;

            for (int i = name.Length - 1; i >= 0; i--)
            {
                reverseName += name[i];
            }

            while (true)
            {
                string password = Console.ReadLine();
                if (password == reverseName)
                {
                    Console.WriteLine($"User {name} logged in.");
                    break;
                }
                if (password != reverseName)
                {
                    counter++;
                    Console.WriteLine("Incorrect password. Try again.");
                    
                }
                if (counter == 3)
                {
                    Console.WriteLine($"User {name} blocked!");
                    break;
                }
            }

        }
    }
}
