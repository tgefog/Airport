using System;
    
namespace Radians_To_Degrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());
            double degrees = rad * 180 / Math.PI;
            Console.WriteLine(degrees);
        }
    }
}