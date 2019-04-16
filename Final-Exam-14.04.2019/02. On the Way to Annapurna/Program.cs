using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._On_the_Way_to_Annapurna
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string[] tokens = input.Split("->");

                if (tokens[0] == "Add")
                {
                    string store = tokens[1];
                    if (tokens[2].Contains(',') == false)
                    {
                        string item = tokens[2];
                        if (!dict.ContainsKey(store))
                        {
                            dict[store] = new List<string>();
                            dict[store].Add(item);
                        }
                        else if (dict.ContainsKey(store))
                        {
                            dict[store].Add(item);
                        }
                    }
                    else if (tokens[2].Contains(','))
                    {
                        List<string> items = tokens[2].Split(',').ToList();
                        if (!dict.ContainsKey(store))
                        {
                            dict[store] = items;
                        }
                        else if (dict.ContainsKey(store))
                        {
                            for (int i = 0; i < items.Count; i++)
                            {
                                string currentItem = items[i];
                                dict[store].Add(currentItem);
                            }
                        }
                    }
                }
                else if (tokens[0] == "Remove")
                {
                    string store = tokens[1];
                    if (dict.ContainsKey(store))
                    {
                        dict.Remove(store);
                    }
                }
            }


            Console.WriteLine("Stores list:");
            foreach (var store in dict.OrderByDescending(x => x.Value.Count()).ThenByDescending(x => x.Key))
            {
                Console.WriteLine($"{store.Key}");
                foreach (var item in store.Value)
                {
                    Console.WriteLine($"<<{item}>>");
                }
            }
        }
    }
}
