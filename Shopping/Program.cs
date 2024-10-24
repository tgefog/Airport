using System;

namespace Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Въвеждаме бюджет double, брой видеокарти int, брой процесори int, брой рам памет int
            double budget = double.Parse(Console.ReadLine());
            int gpus = int.Parse(Console.ReadLine());
            int cpus = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            //2. Пресмятаме цената на всичко, видеокарта 250/бр, процесор 35% от цената на видеокарти/бр, рам 10% от цената на видеокарти/бр
            int gpuprice = gpus * 250;
            double cpuPrice = (gpuprice * 0.35) * cpus;
            double ramPrice = (gpuprice * 0.10) * ram;
            double totalPrice = gpuprice + cpuPrice + ramPrice;
            //3. Ако броя на видеокарти > процесори -> 15% отстъпка от крайната цена
            if (gpus > cpus)
            {
                totalPrice -= totalPrice * 0.15;
            }
            //4. Да се сметне дали бюджета ще му стигне
            if (budget >= totalPrice)
            {
                //ако да => "You have {остатъчен бюджет} leva left!"
                Console.WriteLine($"You have {budget - totalPrice:f2} leva left!");
            }
            else
            {
                //ако не => "Not enough money! You need {нужна сума} leva more!"
                Console.WriteLine($"Not enough money! You need {totalPrice - budget:f2} leva more!");
            }
        }
    }
}