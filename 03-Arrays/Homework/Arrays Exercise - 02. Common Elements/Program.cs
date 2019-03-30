using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Exercise___02.Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine()
                .Split(' ')
                .ToArray();

            string[] array2 = Console.ReadLine()
                .Split(' ')
                .ToArray();

            for (int i = 0; i < array2.Length; i++)
            {
                string currentLetter = array2[i];
                for (int j = 0; j < array.Length; j++)
                {
                    if (currentLetter == array[j])
                    {
                        Console.Write(currentLetter + " ");
                    }
                }
            }

        }
    }
}
