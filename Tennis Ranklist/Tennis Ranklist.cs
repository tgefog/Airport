using System;
namespace Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Четем от конзолата
            //Брой турнири в които е участвал: цяло число
            int tournaments = int.Parse(Console.ReadLine());
            //Начален брой точки : цяло число
            int startingPoints = int.Parse(Console.ReadLine());
            //Променлива за броя точки
            double points = 0;
            //Променлива за спечелените турнири
            double wonTournaments = 0;
            //2. Създаваме цикъл от 1 до броя турнири
            for (int i = 1; i <= tournaments; i++)
            {
                //за всеки турнир се въвежда резултат от турнира -> W(2000), F(1200) или SF(720)
                string result = Console.ReadLine();

                if (result == "W") //При победа (W) се добавят 2000 точки
                {
                    points += 2000;
                    wonTournaments++;
                }
                else if (result == "F") //При финалист се добавят 1200 точки
                    points += 1200;
                else //При полуфинал се добавят 720 точки
                    points += 720;

            }
            double finalPoints = startingPoints + points;
            //3. Отпечатват се краен резултат с текст •	"Final points: {брой точки след изиграните турнири}"
            Console.WriteLine($"Final points: {finalPoints}");
            //"Average points: {средно колко точки печели за турнир}"
            Console.WriteLine($"Average points: {Math.Floor(points / tournaments)}");
            //"{процент спечелени турнири}%"
            Console.WriteLine($"{wonTournaments / tournaments * 100:f2}%");
        }
    }
}