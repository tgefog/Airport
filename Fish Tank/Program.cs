using System;

namespace Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            while (length < 10 || length > 500)
            {
                Console.WriteLine("Invalid entry");
                Console.WriteLine("Enter a new number");
                length = int.Parse(Console.ReadLine());
            }
            int width = int.Parse(Console.ReadLine());
            while (width < 10 || width > 300)
            {
                Console.WriteLine("Invalid entry");
                Console.WriteLine("Enter a new number");
                width = int.Parse(Console.ReadLine());
            }
            int heigth = int.Parse(Console.ReadLine());
            while (heigth < 10 || heigth > 200)
            {
                Console.WriteLine("Invalid entry");
                Console.WriteLine("Enter a new number");
                heigth = int.Parse(Console.ReadLine());
            }
            double percent = double.Parse(Console.ReadLine());
            while (percent < 0.000 || percent > 100.000)
            {
                Console.WriteLine("Invalid entry");
                Console.WriteLine("Enter a new number");
                percent = double.Parse(Console.ReadLine());
            }
            double takenSpace = percent / 100;
            double volume=length*width*heigth;
            double volumeInLitres = volume * 0.001;
            double totalLitresWater = volumeInLitres * (1 - takenSpace);

            Console.WriteLine(totalLitresWater);
        }
    }
}