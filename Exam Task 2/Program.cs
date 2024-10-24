/*
Travel 10||Enemy 30||Repair 15||Titan
50
80


Travel 20||Enemy 50||Enemy 50||Enemy 10||Repair 15||Enemy 50||Titan
60
100
 */
namespace Exam_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> routes = Console.ReadLine().Split("||").ToList();
            int initialFuel = int.Parse(Console.ReadLine());
            int initialAmmo = int.Parse(Console.ReadLine());

            for (int i = 0; i < routes.Count; i++)
            {
                string[] arguments = routes[i].Split(" ").ToArray();

                switch (arguments[0])
                {
                    case "Travel":
                        if (initialFuel >= int.Parse(arguments[1]))
                        {
                            initialFuel -= int.Parse(arguments[1]);
                            Console.WriteLine($"The spaceship travelled {int.Parse(arguments[1])} light-years.");
                        }
                        else
                        {
                            return;
                        }
                        break;
                    case "Enemy":
                        if (initialAmmo >= int.Parse(arguments[1]))
                        {
                            initialAmmo -= int.Parse(arguments[1]);
                            Console.WriteLine($"An enemy with {int.Parse(arguments[1])} armour is defeated.");
                        }
                        else if (initialFuel >= int.Parse(arguments[1]) * 2)
                        {
                            initialFuel -= int.Parse(arguments[1]) * 2;
                            Console.WriteLine($"An enemy with {int.Parse(arguments[1])} armour is outmaneuvered.");
                        }
                        else
                        {
                            Console.WriteLine("Mission failed.");
                            return;
                        }
                        break;
                    case "Repair":
                        initialFuel += int.Parse(arguments[1]);
                        initialAmmo += int.Parse(arguments[1]) * 2;
                        Console.WriteLine($"Ammunitions added: {int.Parse(arguments[1]) * 2}.");
                        Console.WriteLine($"Fuel added: {int.Parse(arguments[1])}.");
                        break;
                    case "Titan":
                        Console.WriteLine("You have reached Titan, all passengers are safe.");
                        break;
                }
            }
        }
    }
}