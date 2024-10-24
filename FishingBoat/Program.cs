using System;

namespace FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Входни данни: Бюджет инт, сезон стринг, брой рибари инт

            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());

            //Пресмятане на цената за риболова // цена за сезони: Пролет - 3000, Лято/Есен - 4200, Зима - 2600

            double price = 0;
            switch (season)
            {
                case "Spring":
                    price = 3000; break;
                case "Summer":
                case "Autumn":
                    price = 4200; break;
                case "Winter":
                    price = 2600; break;
                default:
                    break;
            }

            //В завимост от броя рибари, има отстъпки:
            //   <=6       -> 10% отстъпка
            //   >6 §§ <12 -> 15% отстъпка
            //   >12       -> 25% отстъпка
            if (fishermen <= 6)
            {
                price -= price * 0.10;
            }
            else if (fishermen > 6 && fishermen < 12)
            {
                price -= price * 0.15;
            }
            else
            {
                price -= price * 0.25;
            }
            //четен брой(%2==0) §§ не е есен -> начислява се СЛЕД предната отстъпка
            if (fishermen % 2 == 0 && season != "Autumn")
            {
                price -= price * 0.05;
            }
            //Проверяваме дали ще им стигнат парите за риболова (Сумите трябва да са форматирани с точност до два знака след десетичната запетая.)
            if (budget >= price)
            {
                //Ако бюджетът е достатъчен:
                Console.WriteLine($"Yes! You have {budget - price:f2} leva left.");
            }
            else
            {
                //Ако бюджетът НЕ Е достатъчен: 
                Console.WriteLine($"Not enough money! You need {price - budget:f2} leva.");
            }
        }
    }
}