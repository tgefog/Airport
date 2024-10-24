using System;

namespace Greater_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1=int.Parse(Console.ReadLine());
            int num2=int.Parse(Console.ReadLine());
            int highestNumber;
            if (num1 > num2)
            {
                highestNumber = num1;
            }
            else highestNumber = num2;
            Console.WriteLine(highestNumber);
        }
    }
}