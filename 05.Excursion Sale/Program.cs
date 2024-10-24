using System;
namespace _05.Excursion_Sale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int seaExcursions = int.Parse(Console.ReadLine());
            int mountaintExcursions = int.Parse(Console.ReadLine());
            string trip = string.Empty;
            int totalMoney = 0;
            //Action
            while ((trip = Console.ReadLine()) != "Stop")
            {
                if (trip == "sea" && seaExcursions > 0)
                {
                    totalMoney += 680;
                    seaExcursions--;
                }
                else if (trip == "mountain" && mountaintExcursions > 0)
                {
                    totalMoney += 499;
                    mountaintExcursions--;
                }
                if (seaExcursions == 0 && mountaintExcursions == 0)
                {
                    break;
                }
            }
            //Output
            if (seaExcursions == 0 && mountaintExcursions == 0)
            {
                Console.WriteLine("Good job! Everything is sold.");
            }
            Console.WriteLine($"Profit: {totalMoney} leva.");
        }
    }
}