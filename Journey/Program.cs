using System;
namespace Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //входни данни: бюджет double, сезон string
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double price = 0;
            string destination = "";
            string holiday = "";

            //Бюджета определя дестинацията <=100лв -> България, <=1000лв -> Балканите, >=1000лв ->Eвропа
            if (budget <= 100)
            {
                destination = "Bulgaria";
            }
            else if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";
            }
            else
            {
                destination = "Europe";
            }

            //лято->къмпинг, зима->хотел
            //Европа->хотел
            if (season == "winter" || destination == "Europe")
            {
                holiday = "Hotel";
            }
            else if (season == "summer" && destination != "Europe")
            {
                holiday = "Camp";
            }
            //България(лято -30%, зима -70%), Балканите(лято-40%, зима-80%), Европа(90%)
            if (destination == "Bulgaria")
            {
                if (season == "summer")
                {
                    price = budget * 0.3;
                }
                else
                {
                    price = budget * 0.7;
                }
            }
            else if (destination == "Balkans")
            {
                if (season == "summer")
                {
                    price = budget * 0.4;
                }
                else
                {
                    price = budget * 0.8;
                }
            }
            else
            {
                price = budget * 0.9;
            }

            //Къде ще почива програмиста спрямо бюджета и сезона
            //•	Първи ред – „Somewhere in [дестинация]“ измежду “Bulgaria", "Balkans” и ”Europe”

            Console.WriteLine($"Somewhere in {destination}");
            //•	Втори ред – “{ Вид почивка} – { Похарчена сума}“
            //Почивката може да е между „Camp” и „Hotel” ; Сумата трябва да е закръглена с точност до вторият знак след запетаята.
            Console.WriteLine($"{holiday} - {price:f2}");
        }
    }
}