using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercise___05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> registeredUsers = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                
                if (input[0] == "register")
                {
                    string username = input[1];
                    string licenseNumber = input[2];

                    if (registeredUsers.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licenseNumber}");
                    }
                    else
                    {
                        registeredUsers[username] = licenseNumber;
                        Console.WriteLine($"{username} registered {licenseNumber} successfully");
                    }
                }
                else if (input[0] == "unregister")
                {
                    string username = input[1];

                    if (!registeredUsers.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else if (registeredUsers.ContainsKey(username))
                    {
                        registeredUsers.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
                    
            }

            foreach (var kvp in registeredUsers)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
