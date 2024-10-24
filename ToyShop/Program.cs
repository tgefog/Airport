using System;

namespace ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Четем цена на екскурзията от конзолата

            double vacationCost = double.Parse(Console.ReadLine());

            //2. Четем количество поръчани играчки
            // (пъзели, кукли, мечета, миньони, камиончета)

            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int teddyBears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            //3. Намираме общия брой поръчани играчки 

            int amountOfToys = puzzles + dolls + teddyBears + minions + trucks;

            //4. Намираме цена на поръчката
            //пъзели - 2.60; кукли -3; мечета -4,10; миньони 8,20; камиончета - 2;          

            double sum = puzzles * 2.6 + dolls * 3 + teddyBears * 4.10 + minions * 8.20 + trucks * 2;

            //5. Проверяваме дали броя поръчани играчки >=50, ако са => 25% отстъпка

            if (amountOfToys >= 50)
            {
                sum -= sum * 0.25;
            }

            //6. Изваждаме 10% от печалбата за наем

            sum -= sum * 0.10;

            //Проверяваме дали има достатъчно пари за да отиде на почивка
            //ако има => "Yes! {оставащи пари} lv left.";
            //ако няма => "Not enough money! {необходими пари} lv needed.";
            if (sum >= vacationCost)
            {
                Console.WriteLine($"Yes! {sum - vacationCost:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {vacationCost - sum:f2} lv needed.");
            }
        }
    }
}