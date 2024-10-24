using System;
namespace _03.SantasHoliday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inputs
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string review = Console.ReadLine();
            double totalPrice = 0;
            int nights = days - 1; //11 days=10 nights
            //Action
            if (room == "room for one person")
            {
                totalPrice = nights * 18;
            }
            else if (room == "apartment")
            {
                totalPrice = nights * 25;
                if (days < 10)
                {
                    totalPrice -= totalPrice * 0.3;
                }
                else if (days <= 15)
                {
                    totalPrice -= totalPrice * 0.35;
                }
                else
                {
                    totalPrice -= totalPrice * 0.5;
                }
            }
            else if (room == "president apartment")
            {
                totalPrice = nights * 35;
                if (days < 10)
                {
                    totalPrice -= totalPrice * 0.1;
                }
                else if (days <= 15)
                {
                    totalPrice -= totalPrice * 0.15;
                }
                else
                {
                    totalPrice -= totalPrice * 0.2;
                }
            }
            if (review == "positive")
            {
                totalPrice += totalPrice * 0.25;
            }
            else
            {
                totalPrice -= totalPrice * 0.1;
            }
            //Output
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}