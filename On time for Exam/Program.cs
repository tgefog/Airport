using System;

namespace On_time_for_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Четем от конзолата час и минути на изпита
            int examHour = int.Parse(Console.ReadLine()); //10
            int examMinutes = int.Parse(Console.ReadLine());//30
            //=>Преобразуваме часовете и минутите в минути
            int examTotalMinutes = 60 * examHour + examMinutes;//60*10+30=>630

            //2.Четем от конзолата час и минути на пристигане
            int arriveHour = int.Parse(Console.ReadLine()); //10
            int arriveMinutes = int.Parse(Console.ReadLine()); //10
            // =>преобразуваме часовете и минитуте в минути
            int arriveTotalMinutes = 60 * arriveHour + arriveMinutes;//60*10+10=>610

            //3.Намираме разликата между минутите на изпита и минутите на пристигане
            int difference = examTotalMinutes - arriveTotalMinutes; //630-610->20

            //4.В зависимост от разликата намираме дали е закъснял, подранил или навреме
            if (difference < 0)
            {
                Console.WriteLine("Late");
                //закъснял с по-малко от час
                if (difference > -60)
                {
                    Console.WriteLine($"{Math.Abs(difference)} minutes after the start");
                }
                else//закъснял с повече или точно час
                {
                    Console.WriteLine($"{Math.Abs(difference / 60)}:{Math.Abs(difference % 60):D2} hours after the start");
                }
            }
            else if (difference >= 0 && difference <= 30)
            {
                Console.WriteLine("On time");
                //дошъл е до 30 мин преди изпита
                if (difference > 0)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
            }
            //Повече от 30 мин преди изпита -> подранил
            else //difference > 30
            {
                Console.WriteLine("Early");
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else
                {
                    Console.WriteLine($"{difference / 60}:{difference % 60:D2} hours before the start");
                }
            }
        }
    }
}