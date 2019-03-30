using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_Exercise___10.Poke_Mon__Not_required_
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()); //N
            int M = int.Parse(Console.ReadLine()); //M
            int Y = int.Parse(Console.ReadLine()); //Y
            int pokedTargets = 0;
            int originalPokePower = N;

            while (N > M)
            {
                N -= M;
                pokedTargets++;

                if (N == originalPokePower * 0.5000000)
                {
                    int divided = N / Y;
                    if (divided % 2 == 0)
                    {
                        N /= Y;
                    }
                }
            }

            Console.WriteLine(N);
            Console.WriteLine(pokedTargets);


        }
    }
}
