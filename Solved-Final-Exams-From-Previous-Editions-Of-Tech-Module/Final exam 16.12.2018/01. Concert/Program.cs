using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> bandsDict = new Dictionary<string, List<string>>();
            Dictionary<string, int> bandsAndTheirTimes = new Dictionary<string, int>();
            int totalTime = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "start of concert")
                {
                    break;
                }

                string[] splittedInput = input.Split("; ");

                if (splittedInput[0] == "Add")
                {
                    string bandName = splittedInput[1];
                    string[] bandMembers = splittedInput[2].Split(", ");

                    if (!bandsDict.ContainsKey(bandName))
                    {
                        List<string> bandMembersToAdd = new List<string>();
                        for (int i = 0; i < bandMembers.Length; i++)
                        {
                            bandMembersToAdd.Add(bandMembers[i]);
                        }

                        bandsDict[bandName] = bandMembersToAdd;
                    }
                    else
                    { 
                        for (int i = 0; i < bandMembers.Length; i++)
                        {
                            string currentBandMember = bandMembers[i];

                            if (!bandsDict[bandName].Contains(currentBandMember))
                            {
                                bandsDict[bandName].Add(currentBandMember);
                            }
                        }
                    }
                }
                else if (splittedInput[0] == "Play")
                {
                    string bandName = splittedInput[1];
                    int time = int.Parse(splittedInput[2]);
                    totalTime += time;

                    if (!bandsAndTheirTimes.ContainsKey(bandName))
                    {
                        bandsAndTheirTimes[bandName] = time;
                    }
                    else
                    {
                        bandsAndTheirTimes[bandName] += time;
                    }
                }
            }

            Console.WriteLine($"Total time: {totalTime}");

            foreach (var band in bandsAndTheirTimes.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{band.Key} -> {band.Value}");
            }

            string bandToShow = Console.ReadLine();

            foreach (var band in bandsDict)
            {
                if (bandToShow == band.Key)
                {
                    Console.WriteLine($"{bandToShow}");
                    foreach (var bandMember in bandsDict[bandToShow])
                    {
                        Console.WriteLine($"=> {bandMember}");
                    }
                }
            }
        }
    }
}
