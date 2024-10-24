using System;
namespace Graduation
{
    internal class Graduation
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double yearlyGrade;
            double sumGrades = 0;
            int fails = 0;
            for (int i = 1; i <= 12; i++)
            {
                if (fails <= 1)
                {
                    yearlyGrade = double.Parse(Console.ReadLine());
                    if (yearlyGrade < 4)
                    {
                        fails++;
                    }
                    else
                    {
                        sumGrades += yearlyGrade;
                    }
                }
                else if (fails > 1)
                {
                    Console.WriteLine($"{name} has been excluded at {i - 2} grade");
                    break;
                }

            }
            if (fails <= 1)
            {
                Console.WriteLine($"{name} graduated. Average grade: {sumGrades / 12:f2}");
            }
        }
    }
}