using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Exercise___09_Kamino_Factory__Not_required_
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthOfSequences = int.Parse(Console.ReadLine());
            int[] bestDNA = new int[lengthOfSequences];

            int longestSubSequence = -1;
            int longestSubIndex = -1;
            int longestSubSum = -1;
            int indexOfLongest = 0;
            int indexOfSequence = 1;
            char[] separators = { '!', '?' };

            string input = Console.ReadLine();

            while (input != "Clone them!")
            {
                int[] currentDNA = input
                    .Split((separators), StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int subSequence = 0;
                int subIndex = -1;
                int subSum = 0;
                int count = 0;

                for (int i = 0; i < lengthOfSequences; i++)
                {
                    if (currentDNA[i] == 1)
                    {
                        count++;
                        subSum++;
                        if (count > subSequence)
                        {
                            subSequence = count;
                            subIndex = i - count;
                        }
                    }
                    else
                    {
                        count = 0;
                    }
                }

                if (subSequence > longestSubSequence)
                {
                    longestSubSequence = subSequence;
                    longestSubIndex = subIndex;
                    longestSubSum = subSum;
                    indexOfLongest = indexOfSequence;

                    bestDNA = currentDNA;

                    //for (int i = 0; i < lengthOfSequences; i++)
                    //{
                    //    bestDNA[i] = currentDNA[i];
                    //}
                }
                else if (subSequence == longestSubSequence && longestSubIndex > subIndex)
                {
                    longestSubIndex = subIndex;
                    longestSubSum = subSum;
                    bestDNA = currentDNA;
                    indexOfLongest = indexOfSequence;
                }
                else if (subSequence == longestSubSequence && longestSubIndex == subIndex 
                    && longestSubSum < subSum)
                {
                    longestSubSum = subSum;
                    bestDNA = currentDNA;
                    indexOfLongest = indexOfSequence;
                }

                indexOfSequence++;
                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {indexOfLongest} with sum: {longestSubSum}.");
            Console.WriteLine(string.Join(" ", bestDNA));
        }
    }
}
