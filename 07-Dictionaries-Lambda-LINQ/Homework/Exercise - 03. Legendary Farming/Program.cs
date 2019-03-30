using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercise___03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            keyMaterials.Add("shards", 0);
            keyMaterials.Add("fragments", 0);
            keyMaterials.Add("motes", 0);

            Dictionary<string, int> junkMaterials = new Dictionary<string, int>();

            while (true)
            {
                string[] input = Console.ReadLine().ToLower().Split(' ');
                bool isLegendaryObtained = false;

                for (int i = 0; i < input.Length; i += 2)
                {
                    string material = input[i + 1];
                    int quantity = int.Parse(input[i]);

                    if (material == "shards" || material == "fragments" || material == "motes")
                    {
                        keyMaterials[material] += quantity;

                        if (keyMaterials["shards"] >= 250)
                        {
                            Console.WriteLine("Shadowmourne obtained!");
                            keyMaterials["shards"] -= 250;
                            isLegendaryObtained = true;
                            break;

                        }
                        else if (keyMaterials["fragments"] >= 250)
                        {
                            Console.WriteLine("Valanyr obtained!");
                            keyMaterials["fragments"] -= 250;
                            isLegendaryObtained = true;
                            break;
                        }
                        else if (keyMaterials["motes"] >= 250)
                        {
                            Console.WriteLine("Dragonwrath obtained!");
                            keyMaterials["motes"] -= 250;
                            isLegendaryObtained = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials[material] = 0;
                        }

                        junkMaterials[material] += quantity;
                    }

                }
                if (isLegendaryObtained == true)
                {
                    break;
                }
            }
            

            foreach (var kvp in keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            foreach (var kvp in junkMaterials.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

        }
    }
}
