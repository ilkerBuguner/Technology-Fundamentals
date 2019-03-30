using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_Exercise___06.Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = int.Parse(Console.ReadLine());

            //for (int i = 0; i < num; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        for (int k = 0; k < j; k++)
            //        {
            //            char firstChar = (char)('a' + i);
            //            char secondChar = (char)('b' + i);
            //            char thirdChar = (char)('c' + i);
            //            Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
            //        }
            //    }
            //}

            int n = int.Parse(Console.ReadLine());

            for (char a = 'a'; a < 'a' + n; a++)
            {
                for (char b = 'a'; b < 'a' + n; b++)
                {
                    for (char c = 'a'; c < 'a' + n; c++)
                    {
                        Console.WriteLine($"{a}{b}{c}");
                    }
                }
            }
        }
    }
}
