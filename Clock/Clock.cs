using System;
namespace Clock
{
    internal class Clock
    {
        static void Main(string[] args)
        {
            for (int h = 0; h <= 23; h++)
            {
                for (int m = 0; m <= 59; m++)
                {
                    Console.WriteLine($"{h:D2}:{m:D2}");
                }
            }
        }
    }
}