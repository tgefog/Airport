using System;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studio = 0;
            double apartment = 0;
            switch (month)
            {
                case "May":
                case "October":
                    studio = 50.00;
                    apartment = 65.00;
                    break;
                case "June":
                case "September":
                    studio = 75.20;
                    apartment = 68.70;
                    break;
                case "July":
                case "August":
                    studio = 76.00;
                    apartment = 77.00;
                    break;
                default:
                    break;
            }
            if (nights > 7 && nights < 14)
            {
                if (month == "May" || month == "October")
                {
                    studio -= studio * 0.05;
                }

            }
            else if (nights > 14)
            {
                if (month == "May" || month == "October")
                {
                    studio -= studio * 0.3;
                }

            }
            else if (nights > 14)
            {
                if (month == "June" || month == "September")
                {
                    studio -= studio * 0.2;
                }

            }
            if (nights > 14)
            {
                apartment -= apartment * 0.1;
            }
            Console.WriteLine($"Apartment: {nights * apartment:f2} lv.");
            Console.WriteLine($"Studio: {nights * studio:f2} lv.");
        }
    }
}