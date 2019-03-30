using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercise___09._ForceBook__Not_Required_
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> sidesAndUsersDict = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Lumpawaroo")
                {
                    break;
                }

                string[] tokens = input.Split();

                //bool doesTokensContainsArrow = false;

                //for (int i = 0; i < tokens.Length; i++)
                //{
                //    if (tokens[i] == "->")
                //    {
                //        doesTokensContainsArrow = true;
                //    }
                //}

                if (tokens.Contains("|"))
                {
                    tokens = input.Split(" | ");

                    string side = tokens[0];
                    string userToAdd = tokens[1];

                    if (sidesAndUsersDict.ContainsKey(side) == false)
                    {
                        sidesAndUsersDict[side] = new List<string>();
                    }

                    bool doesNotContains = true;

                    foreach (var kvp in sidesAndUsersDict)
                    {
                        foreach (var item in kvp.Value)
                        {
                            if (item == userToAdd)
                            {
                                doesNotContains = false;
                            }
                        }
                        if (kvp.Value.Count == 0)
                        {
                            sidesAndUsersDict[side].Add(userToAdd);
                        }
                        else if (doesNotContains == false)
                        {
                            sidesAndUsersDict[side].Add(userToAdd);
                        }
                    }
                }
                else if (tokens.Contains("->"))
                {
                    string[] userAndSide = input.Split(" -> ");
                    string userToJoin = userAndSide[0];
                    string side = userAndSide[1];

                    foreach (var kvp in sidesAndUsersDict)
                    {
                        if (kvp.Value.Contains(userToJoin))
                        {
                            kvp.Value.Remove(userToJoin);
                        }
                    }
                    if (sidesAndUsersDict.ContainsKey(side) == false)
                    {
                        sidesAndUsersDict.Add(side, new List<string>());
                    }

                    sidesAndUsersDict[side].Add(userToJoin);
                    Console.WriteLine($"{userToJoin} joins the {side} side!");

                }
            }

            foreach (var kvp in sidesAndUsersDict.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                if (kvp.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count}");

                    foreach (var item in kvp.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"! {item}");
                    }

                }
            }
        }
    }
}
