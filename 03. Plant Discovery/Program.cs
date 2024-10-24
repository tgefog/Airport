namespace _03._Plant_Discovery
{
    /*
     * 
3
Arnoldii<->4
Woodii<->7
Welwitschia<->2
Rate: Woodii - 10
Rate: Welwitschia - 7
Rate: Arnoldii - 3
Rate: Woodii - 5
Update: Woodii - 5
Reset: Arnoldii
Exhibition
     */
    class Plant
    {
        public string Name { get; set; }
        public int Rarity { get; set; }
        public List<int> Ratings { get; set; }
        public Plant(string name, int rarity)
        {
            Name = name;
            Rarity = rarity;
            Ratings = new List<int>();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Plant> plants = new List<Plant>();
            int inputCount = int.Parse(Console.ReadLine());
            string secondInput = string.Empty;
            for (int i = 0; i < inputCount; i++)
            {
                string[] arguments = Console.ReadLine().Split("<->");
                string plantName = arguments[0];
                int plantRarity = int.Parse(arguments[1]);
                if (plants.Any(x => x.Name == plantName))
                {
                    plants.FirstOrDefault(x => x.Name == plantName).Rarity = plantRarity;
                }
                else
                {
                    Plant plant = new Plant(plantName, plantRarity);
                    plants.Add(plant);
                }
            }
            while ((secondInput = Console.ReadLine()) != "Exhibition")
            {
                string[] commands = secondInput.Split(new string[] {": ", " - "}, StringSplitOptions.RemoveEmptyEntries);
                string mainCommand = commands[0];
                string plantsName = commands[1];
                if (!plants.Any(x => x.Name == plantsName))
                {
                    Console.WriteLine("error");
                    continue;
                }
                switch (mainCommand)
                {
                    case "Rate":
                        int rating = int.Parse(commands[2]);
                        plants.First(x => x.Name == plantsName).Ratings.Add(rating);
                        break;
                    case "Update":
                        int rarity = int.Parse(commands[2]);
                        plants.First(x => x.Name == plantsName).Rarity = rarity;
                        break;
                    case "Reset":
                        plants.First(x => x.Name == plantsName).Ratings = new List<int>();
                        break;
                }
            }
            Console.WriteLine("Plants for the exhibition:");
            foreach (Plant plant in plants)
            {
                double rating = 0.0;
                if (plant.Ratings.Any())
                {
                    rating = plant.Ratings.Average();
                }
                Console.WriteLine($"- {plant.Name}; Rarity: {plant.Rarity}; Rating: {rating:f2}");
            }
        }
    }
}