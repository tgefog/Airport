using System.Text.RegularExpressions;

namespace Task2
{
    /*

#@##@red@#/8/@rEd@/2/#@purple@////10/ 
     */
    class Egg
    {
        public string Color { get; set; }
        public int Amount { get; set; }
        public Egg(string color, int amount)
        {
            Color = color;
            Amount = amount;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Egg> eggs = new List<Egg>();
            string input = Console.ReadLine();
            string pattern = @"(?<preColor>[@#]+)(?<color>[a-z]{3,})(?<afterColor>[@#]+)(?<inBetween>[^a-zA-Z\d\s:]*)(?<preAmount>[/]+)(?<amount>\d+)(?<postAmount>[/]+)";

            foreach (Match match in Regex.Matches(input, pattern))
            {
                string color = match.Groups["color"].Value;
                int amount = int.Parse(match.Groups["amount"].Value);
                Egg egg = new Egg(color, amount);
                eggs.Add(egg);
            }
            foreach (Egg egg in eggs)
            {
                Console.WriteLine($"You found {egg.Amount} {egg.Color} eggs!");
            }
        }
    }
}