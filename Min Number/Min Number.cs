using System;
namespace Min_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int minNumber = int.MaxValue;
            while ((input = Console.ReadLine()) != "Stop")
            {
                if (int.Parse(input) < minNumber)
                {
                    minNumber = int.Parse(input);
                }
            }
            Console.WriteLine(minNumber);
        }
    }
}