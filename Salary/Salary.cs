using System;
namespace Salary
{
    internal class Salary
    {
        static void Main(string[] args)
        {

            //1. Четем от конзолата
            //Брой отворени табове в браузъра -> int (цяло число)
            int tabs = int.Parse(Console.ReadLine());
            //Заплата на служителя -> int (цяло число)
            int salary = int.Parse(Console.ReadLine());
            //2. Създаваме цикъл, който да се изпълнява за всеки отворен таб -> от първия(1) до броя отворени табове(tabs)
            for (int tab = 1; tab <= tabs; tab++)
            {
                //Четем име на отворения сайт в конкретния таб -> string (текст)
                string site = Console.ReadLine();
                //Проверяваме дали отворения сайт е : Facebook, Instagram или Reddit 
                // Ако отворения сайт е Facebook
                if (site == "Facebook")
                    //начислява се глоба от 150 лв
                    salary -= 150;
                //Ако отворения сайт е Instagram
                else if (site == "Instagram")
                    //начислява се глоба от 100 лв
                    salary -= 100;
                //Ако отворения сайт е Reddit
                else if (site == "Reddit")
                    //начислява се глоба от 50 лв
                    salary -= 50;
                //Проверяваме дали заплатата на служетеля е свършила(<=0)
                if (salary <= 0)
                {
                    //отпечатваме съобщението
                    Console.WriteLine("You have lost your salary.");
                    //и спираме изпълнението на цикъла
                    break;
                }
            }
            //3. Проверяваме дали е останала заплата на служителя
            if (salary > 0)
            {
                //отпечатваме като цяло число колко пари са му останали
                Console.WriteLine(salary);
            }       
        }
    }
}