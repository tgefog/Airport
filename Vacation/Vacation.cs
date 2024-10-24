using System;
namespace Vacation
{
    internal class Vacation
    {
        static void Main(string[] args)
        {
            //1.Четем от конзолата
            //Пари нужни за екскурзията
            double neededMoney = double.Parse(Console.ReadLine());
            //Налични пари
            double availableMoney = double.Parse(Console.ReadLine());
            //Променливи за:
            string input; //вход от конзолата - spend или save
            double money; //Пари, които тя спестява или харчи         
            int daysCount = 0; //брояч на изминалите дни           
            int spendDaysCount = 0; //брояч на поредните дни в които харчи

            //2.Цикъл, който да се изпълнява докато не събере достатъчно пари
            while (availableMoney < neededMoney)
            {
                //четем действие от конзолата->spend/save
                input = Console.ReadLine();
                //четем сума, която спестява или харчи
                money = double.Parse(Console.ReadLine());
                //увеличаваме брояча на изминалите дни с 1
                daysCount++;

                //Проверяваме дали спестява или харчи
                if (input == "save")//ако спестява
                {
                    //добавяме парите към спестяванията
                    availableMoney += money;
                    //нулираме брояча на поредните, в които харчи
                    spendDaysCount = 0;
                }
                else //ако харчи
                {
                    //увеличаваме брояча на поредните дни с 1
                    spendDaysCount++;
                    //проверяваме дали поредните дни са 5
                    if (spendDaysCount == 5) //ако са 5:
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(daysCount);
                        //спираме изпълнението на цикъла
                        break;
                    }
                    //изваждаме парите от спестяванията
                    availableMoney -= money;
                    //проверяваме длаи парите не са станали <0
                    if (availableMoney < 0)
                    {
                        availableMoney = 0;
                    }
                }
            }
            //3.Проверяваме дали е успяла да спести достатъчно пари
            if (availableMoney >= neededMoney) //Да 
            {
                Console.WriteLine($"You saved the money for {daysCount} days.");
            }
        }
    }
}