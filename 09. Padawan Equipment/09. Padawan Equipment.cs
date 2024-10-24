using System;
namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inputs
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());
            double extraBelts = students / 6;
            double totalEquipmentPrice = 0;

            //Body
            totalEquipmentPrice = (lightsaberPrice * Math.Ceiling(students + students * 0.1)) + (robesPrice * students) + beltsPrice * (students - extraBelts);

            //Result

            if (totalEquipmentPrice > money)
            {
                Console.WriteLine($"John will need {Math.Abs(money - totalEquipmentPrice):f2}lv more.");
            }
            else
            {
                Console.WriteLine($"The money is enough - it would cost {totalEquipmentPrice:f2}lv.");
            }
        }
    }
}