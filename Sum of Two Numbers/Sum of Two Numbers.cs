using System;
namespace Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Num1 = int.Parse(Console.ReadLine());
            int Num2 = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int count = 0;
            bool flag = false;
            for (int i = Num1; i <= Num2; i++)
            {
                for (int j = Num1; j <= Num2; j++)
                {
                    count++;
                    if (i + j == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{count} ({i} + {j} = {magicNumber})");
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
            }
            if (!flag)
            {
                Console.WriteLine($"{count} combinations - neither equals {magicNumber}");
            }

        }
    }
}