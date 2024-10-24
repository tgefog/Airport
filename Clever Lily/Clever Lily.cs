using System;

namespace Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Четем от конзолата:
            //Възрастта на Лили
            int age = int.Parse(Console.ReadLine());
            //Цената на пералнята Double
            double washingMachine = double.Parse(Console.ReadLine());
            //Единична цена на играчка int
            int toyPrice = int.Parse(Console.ReadLine());
            //Парите, които Лили е събрала
            int money = 0;
            //2. Създаваме цикъл който се изпълнява за всеки нейн рожден ден
            for (int i = 1; i <= age; i++)
            {
                //Проверяваме дали Рождения Ден е четен
                if (i % 2 == 0) //Ако да-> получава пари = годините * 5 - 1
                    money += i * 5 - 1;
                else  //Ако не-> получава играчка
                    money += toyPrice;
            }
            //3. Проверяваме дали парите, които е спестила ще стигнат за пералня
            if (money >= washingMachine) //Ако да, принтираме останалите пари след покупката с 2 знака след запетаята
            {
                Console.WriteLine($"Yes! {money - washingMachine:f2}");
            }
            else  //Ако не, принтираме необходимата сума за покупката с 2 знака след запетята
            {
                Console.WriteLine($"No! {washingMachine - money:f2}");
            }
        }
    }
}