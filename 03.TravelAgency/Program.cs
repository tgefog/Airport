using System;
namespace _03.TravelAgency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string townName = Console.ReadLine();
            string packetType = Console.ReadLine();
            string vipDiscount = Console.ReadLine();
            int daysCount = int.Parse(Console.ReadLine());
            if (daysCount < 1)
            {
                Console.WriteLine("Days must be positive number!");
            }
            else
            {
                double pricePerDay = 0;
                double discount = 0;
                if (townName == "Bansko" || townName == "Borovets")
                {
                    if (packetType == "withEquipment")
                    {
                        pricePerDay = 100;
                        discount = 0.10;
                    }
                    else if (packetType == "noEquipment")
                    {
                        pricePerDay = 80;
                        discount = 0.05;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else if (townName == "Varna" || townName == "Burgas")
                {
                    if (packetType == "withBreakfast")
                    {
                        pricePerDay = 130;
                        discount = 0.12;
                    }
                    else if (packetType == "noBreakfast")
                    {
                        pricePerDay = 100;
                        discount = 0.07;
                    }
                }
                if (pricePerDay == 0 && discount == 0)
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    if (vipDiscount == "yes")
                    {
                        pricePerDay -= pricePerDay * discount;
                    }
                    if (daysCount > 7)
                    {
                        daysCount--;
                    }
                    double totalPrice=daysCount* pricePerDay;
                    Console.WriteLine($"The price is {totalPrice:f2}lv! Have a nice time!");
                }
            }
        }
    }
}