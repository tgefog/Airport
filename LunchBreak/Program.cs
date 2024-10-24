using System;
namespace LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Въвеждаме име на сериал (string), продължителност на епизод (int), продължителност на почивка(int)
            string seriesName = Console.ReadLine();
            int seriesDuration = int.Parse(Console.ReadLine());
            int breakDuration = int.Parse(Console.ReadLine());

            //2.Отделяме време за обяд -> 1/8 от почивката и време за отдих -> 1/4 от почивката
            double lunchDuration = breakDuration * 0.125;
            double restDuration = breakDuration * 0.25;
            double finalTime = breakDuration - lunchDuration - restDuration;

            //3. Проверяваме дали ще има време за да изгледа епизода, закръгляме до най-близкото число нагоре
            if (finalTime >= seriesDuration)
            {
                //ако да =>"You have enough time to watch {име на сериал} and left with {останало време} minutes free time."
                Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(finalTime - seriesDuration)} minutes free time.");
            }
            else
            {
                //ако не =>"You don't have enough time to watch {име на сериал}, you need {нужно време} more minutes."
                Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(seriesDuration - finalTime)} more minutes.");
            }
        }
    }
}