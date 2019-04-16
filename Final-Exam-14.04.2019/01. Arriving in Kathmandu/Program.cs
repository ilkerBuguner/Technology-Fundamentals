using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _01._Arriving_in_Kathmandu
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<name>[a-zA-Z0-9!@#$?]+)=(?<length>[0-9]+)<<(?<geohash>[\W\w\D\d]+)";

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Last note")
                {
                    break;
                }

                string geohash = string.Empty;
                int length = 0;
                string name = string.Empty;

                Regex regex = new Regex(pattern);

                if (regex.IsMatch(input))
                {
                    name = regex.Match(input).Groups["name"].Value;
                    length = int.Parse(regex.Match(input).Groups["length"].Value);
                    geohash = regex.Match(input).Groups["geohash"].Value;
                    
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                    continue;
                }
                
                int geohashLength = geohash.Length;

                if (geohashLength != length)
                {
                    Console.WriteLine("Nothing found!");
                    continue;
                }


                string[] tokens = input.Split("=");
                string nameAfterwards = tokens[0];
                bool isFinished = false;
                for (int i = 0; i < nameAfterwards.Length; i++)
                {
                    char currentChar = nameAfterwards[i];
                    if (char.IsLetterOrDigit(currentChar) || currentChar == '!' || currentChar == '@' || currentChar == '#' | currentChar == '$' || currentChar == '?')
                    {
                        continue;
                    }
                    else
                    {
                        isFinished = true;
                        break;
                    }
                    

                }
                if (isFinished)
                {
                    Console.WriteLine("Nothing found!");
                    continue;
                }

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < name.Length; i++)
                {
                    char currentChar = name[i];
                    if (char.IsLetterOrDigit(currentChar))
                    {
                        sb.Append(currentChar);
                    }

                }

                string sbAsString = sb.ToString();
                //if (sbAsString == string.Empty)
                //{
                //    Console.WriteLine("Nothing found!");
                //    continue;
                //}

                Console.WriteLine($"Coordinates found! {sb} -> {geohash}");
            }
        }
    }
}
