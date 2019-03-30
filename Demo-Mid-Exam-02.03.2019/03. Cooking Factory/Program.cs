using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo_mid_exam___03._Cooking_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int qualityOfBestBread = 0;
            double averageQualityOfBestBread = 0;
            int bestBreadsLength = 0;
            List<int> bestBreadBatches = new List<int>();

            while (true)
            {

                string input = Console.ReadLine();

                if (input == "Bake It!")
                {
                    break;
                }

                List<int> currentBreadBatches = input.Split('#', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                int qualityOfCurrentBread = 0;
                double averageQualityOfCurrentBread = 0;
                int currentBreadsLength = currentBreadBatches.Count;

                for (int i = 0; i < currentBreadBatches.Count; i++)
                {
                    qualityOfCurrentBread += currentBreadBatches[i];
                }

                averageQualityOfCurrentBread = (double)qualityOfCurrentBread / currentBreadBatches.Count;


                if (qualityOfBestBread < qualityOfCurrentBread)
                {
                    qualityOfBestBread = qualityOfCurrentBread;
                    averageQualityOfBestBread = averageQualityOfCurrentBread;
                    bestBreadsLength = currentBreadsLength;
                    bestBreadBatches = currentBreadBatches;

                }
                else if (qualityOfBestBread == qualityOfCurrentBread)
                {
                    if (averageQualityOfCurrentBread > averageQualityOfBestBread)
                    {
                        qualityOfBestBread = qualityOfCurrentBread;
                        averageQualityOfBestBread = averageQualityOfCurrentBread;
                        bestBreadsLength = currentBreadsLength;
                        bestBreadBatches = currentBreadBatches;
                    }

                    else if (averageQualityOfCurrentBread == averageQualityOfBestBread)
                    {
                        if (currentBreadsLength < bestBreadsLength)
                        {
                            qualityOfBestBread = qualityOfCurrentBread;
                            averageQualityOfBestBread = averageQualityOfCurrentBread;
                            bestBreadsLength = currentBreadsLength;
                            bestBreadBatches = currentBreadBatches;
                        }
                    }
                }


            }

            Console.WriteLine($"Best Batch quality: {qualityOfBestBread}");

            Console.WriteLine(string.Join(" ", bestBreadBatches));

        }
    }
}
