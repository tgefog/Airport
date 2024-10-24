using System;
namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int input;
            double snowballValue = 0;
            double highestValue = 0;
            int highestSnow = 0;
            int highestTime = 0;
            int highestQuality = 0;
            for (int i = 0; i < n; i++)
            {
                input = int.Parse(Console.ReadLine());
                int snow = input;
                input = int.Parse(Console.ReadLine());
                int time = input;
                input = int.Parse(Console.ReadLine());
                int quality = input;
                snowballValue = Math.Pow((snow / time), quality);
                if (snowballValue > highestValue)
                {
                    highestValue = snowballValue;
                    highestQuality = quality;
                    highestSnow = snow;
                    highestTime = time;
                }
            }
            Console.WriteLine($"{highestSnow} : {highestTime} = {highestValue} ({highestQuality})");
        }
    }
}