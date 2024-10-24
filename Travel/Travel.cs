using System;
namespace Travel
{
    internal class Travel
    {
        static void Main(string[] args)
        {
            //1. Създаваме променливи за:
            //Вход от конзалата
            string input = Console.ReadLine();
            //дестинацията
            string destination = string.Empty;
            //необходимия бюджет
            double budget = 0;
            //2. Създаваме While цикъл, който да се изпълнява докато входа != "End"
            while (input != "End")
            {
                //присвояваме дестинация=вход
                destination = input;
                //четем необходимия бюджет за конкретната дестинация
                budget = double.Parse(Console.ReadLine());
                //създаваме вътрешен While цикъл, който да се изпълнява докато не спести достатъчно
                while (budget > 0)
                {
                    //изваждаме от необходимия бюджет парите, които спестява
                    budget -= double.Parse(Console.ReadLine());
                }
                //след като спести достатъчно -> отпечатваме :
                Console.WriteLine($"Going to {destination}!");
                //четем нов вход от конзолата
                input = Console.ReadLine();
            }

        }
    }
}