using System.Text.RegularExpressions;

namespace _02._AdAstra
{
    class Item
    {
        public string Name { get; set; }
        public string ExpirationDate { get; set; }
        public int Calories { get; set; }
        public Item(string name, string expirationDate, int calories)
        {
            Name = name;
            ExpirationDate = expirationDate;
            Calories = calories;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int caloriesPerDay = 2000;
            int totalCalories = 0;
            List<Item> items = new List<Item>();
            string pattern = @"(#|\|)(?<item>[A-Za-z\s]+)(\1)(?<expirationDate>\d{2}\/\d{2}\/\d{2})(\1)(?<calories>\d+)(\1)";

            RegexOptions options = RegexOptions.Multiline;

            foreach (Match m in Regex.Matches(input, pattern, options))
            {
                string name = m.Groups["item"].Value;
                string expDate = m.Groups["expirationDate"].Value;
                int calories = int.Parse(m.Groups["calories"].Value);
                totalCalories += calories;
                Item item = new Item(name, expDate, calories);
                items.Add(item);
            }


            Console.WriteLine($"You have food to last you for: {totalCalories / caloriesPerDay} days!");
            foreach (var item in items)
            {
                Console.WriteLine($"Item: {item.Name}, Best before: {item.ExpirationDate}, Nutrition: {item.Calories}");
            }
        }
    }
}