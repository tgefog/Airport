using System;

namespace WeekendOrWorkingDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Четем ден от седмицата( string)
            string day = Console.ReadLine();
            //Проверяваме дали е почивен или работен и го записваме, ако е различен -> Error
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    Console.WriteLine("Working day");
                    break;
                case "Saturday":
                case "Sunday":
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}