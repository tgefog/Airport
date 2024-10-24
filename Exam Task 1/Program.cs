/*
10
7
5035.5
11.3
7.2
942.3
500.57
520.68
540.87
505.99
630.3
784.20
321.21
456.8
330

12
6
4430
9.8
5.5
620.3
840.2
960.1
220
340
674
365
345.5
212
412.12
258
496




*/
namespace Exam_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int players = int.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double dailyWater = double.Parse(Console.ReadLine());
            double dailyFood = double.Parse(Console.ReadLine());

            double currentWater = dailyWater * players * days;
            double currentFood = dailyFood * players * days;
            double currentEnergy = energy;

            for (int i = 1; i <= days; i++)
            {
                double energyLoss = double.Parse(Console.ReadLine());
                currentEnergy -= energyLoss;
                if (currentEnergy <= 0)
                {
                    break;
                }
                if (i % 2 == 0)
                {
                    currentEnergy += currentEnergy * 0.05;
                    currentWater -= currentWater * 0.3;
                }
                if (i % 3 == 0)
                {
                    currentFood -= (currentFood / players);
                    currentEnergy += currentEnergy * 0.1;
                }
            }
            if (currentEnergy > 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {currentEnergy:f2} energy!");
            }
            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {currentFood:f2} food and {currentWater:f2} water.");
            }
        }
    }
}