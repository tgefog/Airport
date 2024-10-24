using System;
namespace Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Прочитаме колко е бюджета на филма (double), брой статисти (int) и цената на облекло на всеки статист(double)

            double budget = double.Parse(Console.ReadLine());
            int statics = int.Parse(Console.ReadLine());
            double singularClothingCost = double.Parse(Console.ReadLine());

            //2. Пресмятане на общата цена на облеклото
            double totalClothingCost = statics * singularClothingCost;

            //3. Декорът е на стойност 10% от бюджета

            double decour = budget * 0.10;

            //4. Ако стастите са >150, има отстъпка на цената облеклото 10%
            if (statics > 150)
            {
                totalClothingCost -= totalClothingCost * 0.1;
            }

            //5.Да проверим дали парите за декора и дрехите са повече от бюджета:
            if (decour + totalClothingCost > budget)
            {
                //ако да =>"Not enough money!" "Wingard needs {парите недостигащи за филма} leva more."
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(budget - (decour + totalClothingCost)):f2} leva more.");
            }
            else
            {
                //ако не => "Action!" "Wingard starts filming with {останалите пари} leva left."
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - (decour + totalClothingCost):f2} leva left.");
            }
        }
    }
}