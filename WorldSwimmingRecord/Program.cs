using System;

namespace WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Четем рекордът в секунди (Double), разстоянието в метри ( double) и времето за което плува разстоянието от 1м(double)
            double worldRecordTime = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double secondsPerMeter = double.Parse(Console.ReadLine());

            //2. Да изчислим съпротивлението, забавя го с 12.5с за всеки 15м, закръгля се надолу
            double resistance = Math.Floor(distance / 15) * 12.5;

            //3. Да изчислим времето в секунди за което Иванчо ще преплува разстоянието
            double finalTime = secondsPerMeter * distance + resistance;

            //4. Проверяваме дали е подобрил световния рекорд
            if (finalTime < worldRecordTime)
            {
                //ако да => "Yes, he succeeded! The new world record is {времето на Иван} seconds."
                Console.WriteLine($"Yes, he succeeded! The new world record is {finalTime:f2} seconds.");
            }
            else
            {
                //ако не => "No, he failed! He was {недостигащите секунди} seconds slower."
                Console.WriteLine($"No, he failed! He was {finalTime - worldRecordTime:f2} seconds slower.");
            }
        }
    }
}