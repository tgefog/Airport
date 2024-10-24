using System;
namespace PyramidOfNumber
{
    internal class PyramidOfNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int current = 1;

            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    Console.Write($"{current} ");
                    current++;

                    if (current > n)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                if (current > n)
                {
                    break;
                }
            }
        }
    }
}