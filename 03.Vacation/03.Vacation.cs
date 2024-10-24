using System;
namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            double discount = 0.0;

            if (type == "Students")
            {
                if (people >= 30)
                {
                    discount = 0.15;
                }
                if (day == "Friday")
                {
                    price = people * 8.45;
                    price = price - discount * price;
                }
                else if (day == "Saturday")
                {
                    price = people * 9.8;
                    price = price - discount * price;
                }
                else//Sunday
                {
                    price = people * 10.46;
                    price = price - discount * price;
                }
            }
            else if (type == "Business")
            {
                if (people >= 100)
                {
                    people -= 10;
                }
                if (day == "Friday")
                {
                    price = people * 10.9;
                }
                else if (day == "Saturday")
                {
                    price = people * 15.6;
                }
                else//Sunday
                {
                    price = people * 16;
                }
            }
            else
            {
                if (people > 10 && people < 20)
                {
                    discount=0.05;
                }
                if (day == "Friday")
                {
                    price = people * 15;
                    price = price - discount * price;
                }
                else if (day == "Saturday")
                {
                    price = people * 20;
                    price = price - discount * price;
                }
                else//Sunday
                {
                    price = people * 22.5;
                    price = price - discount * price;
                }
            }
            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}