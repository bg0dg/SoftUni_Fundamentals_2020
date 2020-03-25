using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            //{quantity} {material} {quantity} {material} … {quantity} {material}

            Dictionary<string, int> itemsDict = new Dictionary<string, int>();

            itemsDict["shards"] = 0;
            itemsDict["fragments"] = 0;
            itemsDict["motes"] = 0;


            bool isFinished = false;

            while (isFinished == false)
            {
                List<string> inputLineList = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                for (int i = 0; i < inputLineList.Count; i++)
                {
                    int currentMaterialQty = 0;

                    string material = "";

                    if (i % 2 != 0)
                    {
                        int qty = int.Parse(inputLineList[i - 1]);

                        material = inputLineList[i].ToLower();

                        if (!itemsDict.ContainsKey(material))
                        {
                            itemsDict[material] = 0;
                        }

                        itemsDict[material] += qty;

                        currentMaterialQty = itemsDict[material];
                    }

                    if (currentMaterialQty >= 250 && (material == "shards" || material == "fragments" || material == "motes"))
                    {
                        string legendItem = "";

                        int legendMaterialRest = currentMaterialQty - 250;

                        if (material == "shards")
                        {
                            legendItem = "Shadowmourne";
                            itemsDict["shards"] = legendMaterialRest;

                        }
                        else if (material == "fragments")
                        {
                            legendItem = "Valanyr";
                            itemsDict["fragments"] = legendMaterialRest;
                        }
                        else if (material == "motes")
                        {
                            legendItem = "Dragonwrath";
                            itemsDict["motes"] = legendMaterialRest;
                        }

                        Console.WriteLine($"{legendItem} obtained!");

                        foreach (var kvp in itemsDict.Where(x => x.Key == "shards" || x.Key == "fragments" || x.Key == "motes").OrderByDescending(v => v.Value).ThenBy(k => k.Key))
                        {
                            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                        }

                        foreach (var kvp in itemsDict.Where(x => x.Key != "shards" && x.Key != "fragments" && x.Key != "motes").OrderBy(k => k.Key))
                        {
                            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                        }

                        isFinished = true;
                        break;
                    }

                }

            }
        }
    }
}
