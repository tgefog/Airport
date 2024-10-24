using System;

namespace PersonalTitles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Прочитаме пол и възраст
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            
            //2.Проверяваме по пол
            if (gender == "f")
            {
                //3.Проверяваме по възраст(Под или над 16г)
                if (age >= 16)
                {
                    Console.WriteLine("Ms.");
                }
                else
                {
                    Console.WriteLine("Miss");
                }
            }
            else
            {
                if (age >= 16)
                {
                    Console.WriteLine("Mr.");
                }
                else
                {
                    Console.WriteLine("Master");
                }
            }
        }
    }
}