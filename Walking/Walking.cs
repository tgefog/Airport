using System;
namespace Walking
{
    internal class Walking
    {
        static void Main(string[] args)
        {
            int dailySteps = 10000;
            string input = string.Empty;
            int steps;
            int totalSteps = 0;
            while ((input = Console.ReadLine()) != "Going home")
            {
                steps = int.Parse(input);
                totalSteps += steps;
                if (totalSteps >= dailySteps)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{totalSteps - dailySteps} steps over the goal!");
                    break;
                }
            }
            if (input == "Going home")
            {
                steps = int.Parse(Console.ReadLine());
                totalSteps += steps;
                if (totalSteps >= dailySteps)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{totalSteps - dailySteps} steps over the goal!");
                }
                else
                {
                    Console.WriteLine($"{dailySteps - totalSteps} more steps to reach goal.");
                }
            }
        }
    }
}