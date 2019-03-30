using System;

namespace Mid_Exam___01._Party_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int companions = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int coins = 50 * days;

            for (int i = 1; i <= days; i++)
            {
                if (i % 10 == 0)
                {
                    companions -= 2;
                }

                if (i % 15 == 0)
                {
                    companions += 5;
                }
                
                coins = coins - 2 * companions;

                if (i % 3 == 0)
                {
                    coins = coins - 3 * companions;
                }

                if (i % 5 == 0)
                {
                    coins = coins + 20 * companions;
                    if (i % 3 == 0)
                    {
                        coins = coins - 2 * companions;
                    }
                }
                
                
            }
            int coinsPerPerson = coins / companions;

            Console.WriteLine($"{companions} companions received {coinsPerPerson} coins each.");
        }
    }
}
