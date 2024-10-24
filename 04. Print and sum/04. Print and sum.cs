using System;
namespace _04._Print_and_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondnumber = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = firstNumber; i <= secondnumber; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}