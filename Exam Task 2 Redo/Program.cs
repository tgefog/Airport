/*
Travel 10||Enemy 30||Repair 15||Titan
50
80


Travel 20||Enemy 50||Enemy 50||Enemy 10||Repair 15||Enemy 50||Titan
60
100
 */
namespace Exam_Task_2_Redo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] travelRoutes = Console.ReadLine().Split("||").ToArray();
            int fuel = int.Parse(Console.ReadLine());
            int ammo = int.Parse(Console.ReadLine());
            bool failedMission = false;
            foreach (string route in travelRoutes)
            {
                string[] commands = route.Split(" ");
                string action = commands[0];
                int amount = 0;
                if (commands.Length > 1)
                {
                    amount = int.Parse(commands[1]);
                }
                if (action == "Travel")
                {
                    if (fuel >= amount)
                    {
                        Console.WriteLine($"The spaceship travelled {amount} light-years.");
                        fuel -= amount;
                    }
                    else
                    {
                        failedMission = true;
                        break;
                    }
                }
                if (action == "Enemy")
                {
                    if (ammo >= amount)
                    {
                        ammo -= amount;
                        Console.WriteLine($"An enemy with {amount} armour is defeated.");
                    }
                    else if (fuel > amount * 2)
                    {
                        fuel -= amount * 2;
                        Console.WriteLine($"An enemy with {amount} armour is outmaneuvered.");
                    }
                    else
                    {
                        failedMission = true;
                        break;
                    }
                }
                if (action == "Repair")
                {
                    fuel += amount;
                    ammo += amount * 2;
                    Console.WriteLine($"Ammunitions added: {amount * 2}.");
                    Console.WriteLine($"Fuel added: {amount}.");
                }
                if (action == "Titan")
                {
                    Console.WriteLine("You have reached Titan, all passengers are safe.");
                }
            }
            if (failedMission)
            {
                Console.WriteLine("Mission failed.");
            }
        }
    }
}