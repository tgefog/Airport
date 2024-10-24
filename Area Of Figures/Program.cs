using System;

namespace Area_Of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double result = 0;
            if (figure == "square")
            {
                double size = double.Parse(Console.ReadLine());
                result = size * size;
            }
            else if (figure == "circle")
            {
                double size = double.Parse(Console.ReadLine());
                result = size * size * Math.PI;

            }
            else if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                result = a * b / 2;
            }
            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                result = a * b;
            }
            Console.WriteLine($"{result:f3}");
        }
    }
}