using System;
namespace _05.FitnessCenter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int visitors = int.Parse(Console.ReadLine());

            int backTrainingCount = 0;
            int chestTrainingCount = 0;
            int legsTrainingCount = 0;
            int absTrainingCount = 0;
            int proteinShakesSold = 0;
            int proteinBarsSold = 0;
            //Action
            for (int i = 1; i <= visitors; i++)
            {
                string action = Console.ReadLine();
                if (action == "Back")
                {
                    backTrainingCount++;
                }
                else if (action == "Chest")
                {
                    chestTrainingCount++;
                }
                else if (action == "Legs")
                {
                    legsTrainingCount++;
                }
                else if (action == "Abs")
                {
                    absTrainingCount++;
                }
                else if (action == "Protein shake")
                {
                    proteinShakesSold++;
                }
                else if (action == "Protein bar")
                {
                    proteinBarsSold++;
                }
            }
            int totalPeopleWorkingOut = (backTrainingCount + chestTrainingCount + legsTrainingCount + absTrainingCount);
            int totalPeopleBuyingThings = visitors - totalPeopleWorkingOut;

            double workingOutPeoplePercentage = ((double)totalPeopleWorkingOut / visitors) * 100;
            double buyersPercentage = ((double)totalPeopleBuyingThings / visitors) * 100;
            //Output
            Console.WriteLine($"{backTrainingCount} - back");
            Console.WriteLine($"{chestTrainingCount} - chest");
            Console.WriteLine($"{legsTrainingCount} - legs");
            Console.WriteLine($"{absTrainingCount} - abs");
            Console.WriteLine($"{proteinShakesSold} - protein shake");
            Console.WriteLine($"{proteinBarsSold} - protein bar");
            Console.WriteLine($"{workingOutPeoplePercentage:f2}% - work out");
            Console.WriteLine($"{buyersPercentage:f2}% - protein");
        }
    }
}