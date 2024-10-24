using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, AnimalInfo> animals = new Dictionary<string, AnimalInfo>();
        Dictionary<string, int> hungryAnimalsPerArea = new Dictionary<string, int>();

        string input;
        while ((input = Console.ReadLine()) != "EndDay")
        {
            string[] commandArgs = input.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            string command = commandArgs[0].Trim();

            if (command == "Add")
            {
                string animalName = commandArgs[1].Trim();
                int foodQuantity = int.Parse(commandArgs[2].Trim());
                string area = commandArgs[3].Trim();

                if (!animals.ContainsKey(animalName))
                {
                    animals.Add(animalName, new AnimalInfo(foodQuantity, area));
                    if (!hungryAnimalsPerArea.ContainsKey(area))
                    {
                        hungryAnimalsPerArea.Add(area, 1);
                    }
                    else
                    {
                        hungryAnimalsPerArea[area]++;
                    }
                }
                else
                {
                    animals[animalName].NeededFood += foodQuantity;
                }
            }
            else if (command == "Feed")
            {
                string animalName = commandArgs[1].Trim();
                int foodQuantity = int.Parse(commandArgs[2].Trim());

                if (animals.TryGetValue(animalName, out AnimalInfo animal))
                {
                    animal.NeededFood -= foodQuantity;
                    if (animal.NeededFood <= 0)
                    {
                        Console.WriteLine($"{animalName} was successfully fed");
                        string animalArea = animal.Area;
                        hungryAnimalsPerArea[animalArea]--;
                        if (hungryAnimalsPerArea[animalArea] == 0)
                        {
                            hungryAnimalsPerArea.Remove(animalArea);
                        }
                        animals.Remove(animalName);
                    }
                }
            }
        }

        Console.WriteLine("Animals:");
        foreach (var animal in animals)
        {
            Console.WriteLine($" {animal.Key} -> {animal.Value.NeededFood}g");
        }

        Console.WriteLine("Areas with hungry animals:");
        foreach (var areaEntry in hungryAnimalsPerArea)
        {
            Console.WriteLine($" {areaEntry.Key}: {areaEntry.Value}");
        }
    }
}

class AnimalInfo
{
    public int NeededFood { get; set; }
    public string Area { get; set; }

    public AnimalInfo(int neededFood, string area)
    {
        NeededFood = neededFood;
        Area = area;
    }
}
