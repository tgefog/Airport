using System;
namespace Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int maxNumber = int.MinValue;
            while ((input = Console.ReadLine()) != "Stop")
            {
                if (int.Parse(input) > maxNumber)
                {
                    maxNumber = int.Parse(input);
                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}