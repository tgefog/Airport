using System;
namespace Combinations
{
    internal class Combinations
    {
        static void Main(string[] args)
        {
            int Number = int.Parse(Console.ReadLine());
            int validCombinations = 0;
            for (int x1 = 0; x1 <= Number; x1++)
            {
                for (int x2 = 0; x2 <= Number; x2++)
                {
                    for (int x3 = 0; x3 <= Number; x3++)
                    {
                        if (x1 + x2 + x3 == Number)
                        {
                            validCombinations++;
                        }
                    }
                }
            }
            Console.WriteLine(validCombinations);
        }
    }
}