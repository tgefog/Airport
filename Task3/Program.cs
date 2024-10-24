namespace Task3
{
    /*
Add: Adam-4500-ByTheCreek
Add: Maya-7600-WaterfallArea
Add: Maya-1230-WaterfallArea
Feed: Jamie-2000
EndDay

Add: Jamie-600-WaterfallArea
Add: Maya-6570-WaterfallArea
Add: Adam-4500-ByTheCreek
Add: Bobbie-6570-WaterfallArea
Feed: Jamie-2000
Feed: Adam-2000
Feed: Adam-2500
EndDay
     */
    class Animal
    {
        public string Name { get; set; }
        public int Food { get; set; }

        public string Area { get; set; }
        public Animal(int food, string area)
        {
            Food = food;
            Area = area;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Animal> animals = new Dictionary<string, Animal>();
            Dictionary<string, int> hungryAnimalsPerArea = new Dictionary<string, int>();
            string command;
            string[] splitters = { ": ", "-" };
            while ((command = Console.ReadLine()) != "EndDay")
            {
                string[] arguments = command.Split(splitters, StringSplitOptions.None);
                switch (arguments[0])
                {
                    case "Add":
                        string animalName = arguments[1];
                        int neededFood = int.Parse(arguments[2]);
                        string area = arguments[3];
                        Animal animal = new Animal(neededFood, area);
                        if (!animals.ContainsKey(animalName))
                        {
                            animals.Add(animalName, animal);
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
                            animals[animalName].Food += neededFood;
                        }
                        break;
                    case "Feed":
                        animalName = arguments[1];
                        int food = int.Parse(arguments[2]);
                        if (animals.ContainsKey(animalName))
                        {
                            animals[animalName].Food -= food;
                            if (animals[animalName].Food <= 0)
                            {
                                Console.WriteLine($"{animalName} was successfully fed");
                                string animalArea = animals[animalName].Area;
                                hungryAnimalsPerArea[animalArea]--;
                                if (hungryAnimalsPerArea[animalArea] == 0)
                                {
                                    hungryAnimalsPerArea.Remove(animalArea);
                                }
                                animals.Remove(animalName);
                            }
                        }
                        break;
                }
            }
            Console.WriteLine("Animals:");
            foreach (var animal in animals)
            {
                Console.WriteLine($" {animal.Key} -> {animal.Value.Food}g");
            }

            Console.WriteLine("Areas with hungry animals:");
            foreach (var areaEntry in hungryAnimalsPerArea)
            {
                Console.WriteLine($" {areaEntry.Key}: {areaEntry.Value}");
            }
        }
    }
}