using System;
namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inputs
            int orders = int.Parse(Console.ReadLine());
            double price = 0;
            int days = 0;
            int capsules = 0;
            double calculatedPrice = 0;
            double totalPrice = 0;
            //Body
            for (int i = 0; i < orders; i++)
            {
                price = double.Parse(Console.ReadLine());
                days = int.Parse(Console.ReadLine());
                capsules = int.Parse(Console.ReadLine());
                calculatedPrice = (days * capsules) * price;
                totalPrice += calculatedPrice;
                Console.WriteLine($"The price for the coffee is: ${calculatedPrice:f2}");
                
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}