using System;
namespace _09._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int DNALength = int.Parse(Console.ReadLine());
            string input;
            int bestSequenceIndex = 0;
            int bestSequenceSum = 0;
            while ((input = Console.ReadLine()) != "Clone them!")
            {
                input.Split("!").Select(int.Parse).ToArray();

            }


            Console.WriteLine("Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}.");
            Console.WriteLine();
        }
    }
}