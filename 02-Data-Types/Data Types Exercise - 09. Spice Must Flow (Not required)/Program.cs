using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_Exercise___09.Spice_Must_Flow__Not_required_
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYeld = int.Parse(Console.ReadLine());
            int minedYeld = 0;
            int days = 0;

            while (startingYeld >= 100)
            {
                minedYeld += startingYeld;
                days++;

                startingYeld -= 10;

                if (minedYeld >= 26)
                {
                    minedYeld -= 26;
                }

            }

            if (minedYeld >= 26)
            {
                minedYeld -= 26;
            }


            Console.WriteLine(days);
            Console.WriteLine(minedYeld);
        }
    }
}
