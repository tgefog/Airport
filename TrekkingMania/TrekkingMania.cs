using System;
namespace TrekkingMania
{
    internal class TrekkingMania
    {
        static void Main(string[] args)
        {
            //1. Четем от конзола:
            //Поредица от числа, всяко на отделен ред
            //На първия ред – броя на групите от катерачи – цяло число в интервала [1...1000]
            int groups = int.Parse(Console.ReadLine());
            //Създаваме променливи за броя хора във всяка група
            int peopleGroup1 = 0;
            int peopleGroup2 = 0;
            int peopleGroup3 = 0;
            int peopleGroup4 = 0;
            int peopleGroup5 = 0;
            for (int i = 1; i <= groups; i++)
            {
                //За всяка една група на отделен ред – броя на хората в групата – цяло число в интервала [1...1000]
                int people = int.Parse(Console.ReadLine());
                if (people < 6)       //Група до 5 човека – изкачват Мусала
                {
                    peopleGroup1 += people;
                }
                else if (people < 13) //Група от 6 до 12 човека – изкачват Монблан
                {
                    peopleGroup2 += people;
                }
                else if (people < 26)//Група от 13 до 25 човека – изкачват Килиманджаро
                {
                    peopleGroup3 += people;
                }
                else if (people < 41)//Група от 26 до 40 човека –  изкачват К2
                {
                    peopleGroup4 += people;
                }
                else//Група от 41 или повече човека – изкачват Еверест
                {
                    peopleGroup5 += people;
                }
            }
            //Смятане на общия брой хора, които ще изкачват върхове
            int sumPeople = peopleGroup1 + peopleGroup2 + peopleGroup3 + peopleGroup4 + peopleGroup5;
            //Oтпечатване на % броя хора във всяка група
            Console.WriteLine($"{(double)peopleGroup1 / sumPeople * 100:f2}%");
            Console.WriteLine($"{(double)peopleGroup2 / sumPeople * 100:f2}%");
            Console.WriteLine($"{(double)peopleGroup3 / sumPeople * 100:f2}%");
            Console.WriteLine($"{(double)peopleGroup4 / sumPeople * 100:f2}%");
            Console.WriteLine($"{(double)peopleGroup5 / sumPeople * 100:f2}%");
        }
    }
}