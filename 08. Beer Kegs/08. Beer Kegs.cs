using System;
namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input;
            double size;
            double biggestKeg = 0;
            string biggestKegName="";
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                size = double.Parse(Console.ReadLine());
                double radius = size;
                size = double.Parse(Console.ReadLine());
                double height = size;
                double currentKeg = Math.PI * radius * radius * height;
                if (currentKeg > biggestKeg)
                {
                    biggestKeg = currentKeg;
                    biggestKegName = input;
                }
            }
            Console.WriteLine(biggestKegName);
        }
    }
}