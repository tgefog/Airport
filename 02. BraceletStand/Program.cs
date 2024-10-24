using System;
namespace _02._BraceletStand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            double pocketMoney = double.Parse(Console.ReadLine());
            double salesMoney = double.Parse(Console.ReadLine());
            double expenseMoney = double.Parse(Console.ReadLine());
            double giftCost = double.Parse(Console.ReadLine());
            double totalMoney = 0;
            //Action

            totalMoney += pocketMoney * 5; //Pocket money for 5 days
            totalMoney += salesMoney * 5;   //Sales money for 5 days
            totalMoney -= expenseMoney;
            //Output
            if (totalMoney > giftCost)
            {
                Console.WriteLine($"Profit: {totalMoney:f2} BGN, the gift has been purchased.");
            }
            else
            {
                Console.WriteLine($"Insufficient money: {giftCost - totalMoney:f2} BGN.");
            }
        }
    }
}