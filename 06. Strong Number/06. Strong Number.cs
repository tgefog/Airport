using System;
namespace _06._Strong_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int j = number; j > 0; j = j / 10)
            {
                int fact = 1;
                for (int i = 1; i <= j % 10; i++)
                {
                    fact = fact * i;
                }
                sum = sum + fact;

            }
            if (sum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}