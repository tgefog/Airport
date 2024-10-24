using System;
namespace _08._Triangle_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int current = 1;
            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 0; cols <= rows; cols++)
                {
                    Console.Write($"{current} ");
                }
                current++;
                Console.WriteLine();
                if (current>n)
                {
                    break;
                }
            }
        }
    }
}