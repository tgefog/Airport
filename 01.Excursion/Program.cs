using System;
namespace _01.Excursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int people = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine()); //20
            int cards = int.Parse(Console.ReadLine());  //1.60
            int tickets = int.Parse(Console.ReadLine()); //6
            double totalPrice = 0;

            //Action
            double nightsCost = nights * 20;
            double cardsCost = cards * 1.6;
            double ticketsCost = tickets * 6;
            //Price for 1 person
            double sumForOnePerson = nightsCost + cardsCost + ticketsCost;
            //Price for everyone
            totalPrice = sumForOnePerson * people;
            //25% bonus after we find the whole sum
            totalPrice = totalPrice + totalPrice * 0.25;
            
            //Output
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}