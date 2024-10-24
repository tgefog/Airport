using System;
namespace _04.Workout
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int days = int.Parse(Console.ReadLine());
            double firstDayKMs = double.Parse(Console.ReadLine());
            double dailyKMs = firstDayKMs;
            double totalKMs = firstDayKMs;
            //Action
            for (int i = 1; i <= days; i++)
            {
                int percentIncrease = int.Parse(Console.ReadLine());
                dailyKMs += dailyKMs * percentIncrease / 100.0;
                totalKMs += dailyKMs;
            }
            //Output
            if (totalKMs < 1000)
            {
                double neededKms = Math.Ceiling(1000 - totalKMs);
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {neededKms} more kilometers");
            }
            else
            {
                double extraKms = Math.Ceiling(totalKMs - 1000);
                Console.WriteLine($"You've done a great job running {extraKms} more kilometers!");
            }
        }
    }
}