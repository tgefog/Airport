using System;
namespace Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Четем от конзолата дните за престой, вида помещение и оценката му
            int days = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string grade = Console.ReadLine();
            double cost = 0;
            //2.Пресмятаме броя нощувки
            int nights = days - 1;
            //3.При наемане на единична стая
            if (type == "room for one person")
            {
                cost = nights * 18;
            }
            //при наемана на апартамент
            else if (type == "apartment")
            {
                cost = nights * 25;
                //отстъпка за по-малко от 10 дни
                if (days < 10)
                {
                    cost -= cost * 0.3;
                }
                //отстъпка за между 10 и 15 дни
                else if (days >= 10 && days < 15)
                {
                    cost -= cost * 0.35;
                }
                else //отстъпка за повече от 15 дни
                {
                    cost -= cost * 0.5;
                }
            }
            //при наемане на президентски апартамент
            else if (type == "president apartment")
            {
                cost = nights * 35;
                //отстъпка за по-малко от 10 дни
                if (days < 10)
                {
                    cost -= cost * 0.1;
                }
                //отстъпка за между 10 и 15 дни
                else if (days >= 10 && days < 15)
                {
                    cost -= cost * 0.15;
                }
                else //отстъпка за повече от 15 дни
                {
                    cost -= cost * 0.2;
                }
            }
            //4. Пресмятане на намаления в зависимост от оценката
            if (grade == "positive")
            {
                cost += cost * 0.25;
            }
            else
            {
                cost -= cost * 0.1;
            }
            Console.WriteLine($"{cost:f2}");
        }
    }
}