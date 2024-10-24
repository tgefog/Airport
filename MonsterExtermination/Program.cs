namespace MonsterExtermination
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queue<int> armours = new Queue<int>(Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> strikes = new Stack<int>(Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            int killedMonsters = 0;
            while (armours.Any() && strikes.Any())
            {
                int currentArmour = armours.Dequeue();
                int currentStrike = strikes.Pop();
                if (currentStrike >= currentArmour)
                {
                    killedMonsters++;
                    currentStrike -= currentArmour;
                    if (strikes.Any())
                    {
                        int nextStrike = strikes.Pop();
                        nextStrike += currentStrike;
                        strikes.Push(nextStrike);
                    }
                    else if (currentStrike > 0)
                    {
                        strikes.Push(currentStrike);
                    }
                }
                else
                {
                    currentArmour -= currentStrike;
                    armours.Enqueue(currentArmour);
                }
            }
            if (!armours.Any())
            {
                Console.WriteLine("All monsters have been killed!");
            }
            if (!strikes.Any())
            {
                Console.WriteLine("The soldier has been defeated.");
            }
            Console.WriteLine($"Total monsters killed: {killedMonsters}");
        }
    }
}