using System;
namespace SumNumberss
{
    internal class SumNumberss
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int input = int.Parse(Console.ReadLine());
            int sum = input;
            while (sum < number)
            {
                input=int.Parse(Console.ReadLine());
                sum += input;
            }
            Console.WriteLine(sum);
        }
    }
}