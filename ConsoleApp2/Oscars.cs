using System;
namespace Oscars
{
    internal class Oscars
    {
        static void Main(string[] args)
        {
            //1. Четем от конзолата
            //Име на актьор -> string(текст)
            string actor = Console.ReadLine();
            //Точки от академията -> double (дробно число)
            double academyPoints = double.Parse(Console.ReadLine());
            //Брой оценяващи -> int (цяло число)
            int judges = int.Parse(Console.ReadLine());
            //Променлива за крайния брой точки
            double totalPoints = academyPoints;
            //2. Правим цикъл за добавяне на точки от оценяващи( от 1 до брой оценяващи)
            for (int i = 1; i <= judges; i++)
            {
                //Въвеждаме име на оценяващия
                string name = Console.ReadLine();
                //Въвеждаме точки на оценяващия
                double points = double.Parse(Console.ReadLine());
                //Точките на актьора се формират от (дължината на името на оценяващия*точките,които дава) делено на 2 
                totalPoints += name.Length * points / 2.0;
                //3.Ако точките надминат 1250.5
                if (totalPoints > 1250.5)
                {
                    //Изписваме съобщение "Congratulations, {име на актьора} got a nominee for leading role with {точки}!"
                    Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {totalPoints:f1}!");
                    //Прекъсваме цикъла
                    break;
                }
            }
            //Ако не са достатъчни
            if (totalPoints <= 1250.5)
            {
                //Изписваме съобщение "Sorry, {име на актьора} you need {нужни точки} more!"
                Console.WriteLine($"Sorry, {actor} you need {1250.5 - totalPoints:f1} more!");
            }
        }
    }
}