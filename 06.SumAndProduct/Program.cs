using System;
namespace _06.SumAndProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int n = int.Parse(Console.ReadLine());
            bool combinationFound = false;
            //Action
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 9; b > a; b--)
                {
                    for (int c = 0; c < 9; c++)
                    {
                        for (int d = 9; d > c; d--)
                        {
                            if ((a + b + c + d) == (a * b * c * d) && n % 10 == 5)
                            {

                                Console.WriteLine($"{a}{b}{c}{d}");
                                combinationFound = true;
                                break;//also works with return

                            }
                            else if ((a * b * c * d) / (a + b + c + d) == 3 && n % 3 == 0)
                            {

                                Console.WriteLine($"{d}{c}{b}{a}");
                                combinationFound = true;
                                break;//also works with return
                            }
                        }
                        if (combinationFound == true)
                            break;
                    }
                    if (combinationFound == true)
                        break;
                }
                if (combinationFound == true)
                    break;
            }
            if (combinationFound == false)
                Console.WriteLine("Nothing found");
        }
    }
}