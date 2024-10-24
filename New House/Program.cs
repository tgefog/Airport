using System;
namespace New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //входни данни: вид цветя стринг, брой цветя инт, бюджет инт (ЦЕНА: Роза : 5, Далия : 3.8, Лале : 2.8 Нарцис : 3, Гладиола : 2.5)

            string flower = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0;

            //Промени в цената : >80 Рози -> 10% отстъпка
            //                   >90 Далии -> 15% отстъпка
            //                   >80 Лалета -> 15% отстъпка
            //                   <120 Марциси -> 15% ПОВЕЧЕ
            //                   <80 Гладиоли -> 20% ПОВЕЧЕ
            if (flower == "Roses")
            {
                if (quantity > 80)
                {
                    price = (quantity * 5) * 0.9;
                }
                else
                {
                    price = quantity * 5;
                }
            }
            else if (flower == "Dahlias")
            {
                if (quantity > 90)
                {
                    price = (quantity * 3.8) * 0.85;
                }
                else
                {
                    price = quantity * 3.8;
                }
            }
            else if (flower == "Tulips")
            {
                if (quantity > 80)
                {
                    price = (quantity * 2.8) * 0.85;
                }
                else
                {
                    price = quantity * 2.8;
                }
            }
            else if (flower == "Narcissus")
            {
                if (quantity < 120)
                {
                    price = (quantity * 3) * 1.15;
                }
                else
                {
                    price = quantity * 3;
                }
            }
            else if (flower == "Gladiolus")
            {
                if (quantity < 80)
                {
                    price = (quantity * 2.5) * 1.20;
                }
                else
                {
                    price = quantity * 2.5;
                }
            }

            //Да се отпечата на конзолата на един ред: форматирано до 2ри знак

            if (budget >= price)
            {
                //Ако бюджета им е достатъчен
                Console.WriteLine($"Hey, you have a great garden with {quantity} {flower} and {budget - price:f2} leva left.");
            }
            else
            {
                //Ако бюджета им е НЕ достатъчен
                Console.WriteLine($"Not enough money, you need {price - budget:f2} leva more.");
            }
        }
    }
}