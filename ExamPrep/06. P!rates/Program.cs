using System.Numerics;

namespace _06._P_rates
{
    class City
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public int Gold { get; set; }
        public City(string name, int population, int gold)
        {
            Name = name;
            Population = population;
            Gold = gold;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<City> cities = new List<City>();
            string cityInfo = string.Empty;
            string commands = string.Empty;
            int totalGold = 0;
            while ((cityInfo = Console.ReadLine()) != "Sail")
            {
                string[] arguments = cityInfo.Split("||");
                string cityName = arguments[0];
                int cityPop = int.Parse(arguments[1]);
                int cityGold = int.Parse(arguments[2]);
                if (!cities.Any(x => x.Name == cityName))
                {
                    cities.Add(new City(cityName, cityPop, cityGold));
                }
                else
                {
                    cities.FirstOrDefault(x => x.Name == cityName).Population += cityPop;
                    cities.FirstOrDefault(x => x.Name == cityName).Gold += cityGold;
                }
            }
            while ((commands = Console.ReadLine()) != "End")
            {
                string[] events = commands.Split("=>");
                switch (events[0])
                {
                    case "Plunder":
                        string plunderedCity = events[1];
                        int peopleKilled = int.Parse(events[2]);
                        int goldStolen = int.Parse(events[3]);
                        if (cities.Any(x => x.Name == plunderedCity))
                        {
                            cities.FirstOrDefault(x => x.Name == plunderedCity).Population -= peopleKilled;
                            cities.FirstOrDefault(x => x.Name == plunderedCity).Gold -= goldStolen;
                        }
                        Console.WriteLine($"{plunderedCity} plundered! {goldStolen} gold stolen, {peopleKilled} citizens killed.");
                        if (cities.FirstOrDefault(x => x.Name == plunderedCity).Population == 0 ||
                            cities.FirstOrDefault(x => x.Name == plunderedCity).Gold == 0)
                        {
                            cities.RemoveAll(x => x.Name == plunderedCity);
                            Console.WriteLine($"{plunderedCity} has been wiped off the map!");
                        }
                        break;
                    case "Prosper":
                        string townName = events[1];
                        int goldGained = int.Parse(events[2]);
                        if (goldGained < 0)
                        {
                            Console.WriteLine("Gold added cannot be a negative number!");
                        }
                        else
                        {
                            cities.FirstOrDefault(x => x.Name == townName).Gold += goldGained;
                            Console.WriteLine($"{goldGained} gold added to the city treasury. {townName} now has {cities.FirstOrDefault(x => x.Name == townName).Gold} gold.");
                        }
                        break;
                }
            }
            if (cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                foreach (City city in cities)
                {
                    Console.WriteLine($"{city.Name} -> Population: {city.Population} citizens, Gold: {city.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}