namespace Problem_2._MuOnline
{
    internal class Program
    {
        /*
         rat 10|bat 20|potion 10|rat 10|chest 100|boss 70|chest 1000
         cat 10|potion 30|orc 10|chest 10|snake 25|chest 110
         */
        static void Main(string[] args)
        {
            int health = 100;
            int bitCoins = 0;
            int currentRoom = 0;
            string[] dungeonsRooms = Console.ReadLine().Split("|").ToArray();
            foreach (string room in dungeonsRooms)
            {
                currentRoom++;
                string[] roomTokens = room.Split(" ");
                string encounter = roomTokens[0];
                int amount = int.Parse(roomTokens[1]);
                if (encounter == "potion")
                {
                    if (health + amount > 100)
                    {
                        Console.WriteLine($"You healed for {100 - health} hp.");
                        health = 100;
                    }
                    else
                    {
                        health += amount;
                        Console.WriteLine($"You healed for {amount} hp.");
                    }
                    Console.WriteLine($"Current health: {health} hp.");
                    continue;
                }
                if (encounter == "chest")
                {
                    bitCoins += amount;
                    Console.WriteLine($"You found {amount} bitcoins.");
                    continue;
                }
                health -= amount;
                if (health <= 0)
                {
                    Console.WriteLine($"You died! Killed by {encounter}.");
                    Console.WriteLine($"Best room: {currentRoom}");
                    break;
                }
                Console.WriteLine($"You slayed {encounter}.");

            }
            if (health > 0)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitCoins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}