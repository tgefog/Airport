using System;

namespace Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            bool isWeekend = false;
            bool isValid = false;
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    isWeekend = false;
                    isValid = true;
                    break;
                case "Saturday":
                case "Sunday":
                    isWeekend = true;
                    isValid = true;
                    break;
                default:
                    isValid = false;
                    break;
            }
            if (fruit == "banana" && isValid == true)
            {
                if (isWeekend == true)
                {
                    Console.WriteLine($"{quantity * 2.7:f2}");
                }
                else
                {
                    Console.WriteLine($"{quantity * 2.5:f2}");
                }
            }
            else if (fruit == "apple" && isValid == true)
            {
                if (isWeekend == true)
                {
                    Console.WriteLine($"{quantity * 1.25:f2}");
                }
                else
                {
                    Console.WriteLine($"{quantity * 1.20:f2}");
                }
            }
            else if (fruit == "orange" && isValid == true)
            {
                if (isWeekend == true)
                {
                    Console.WriteLine($"{quantity * 0.90:f2}");
                }
                else
                {
                    Console.WriteLine($"{quantity * 0.85:f2}");
                }
            }
            else if (fruit == "grapefruit" && isValid == true)
            {
                if (isWeekend == true)
                {
                    Console.WriteLine($"{quantity * 1.60:f2}");
                }
                else
                {
                    Console.WriteLine($"{quantity * 1.45:f2}");
                }
            }
            else if (fruit == "kiwi" && isValid == true)
            {
                if (isWeekend == true)
                {
                    Console.WriteLine($"{quantity * 3.00:f2}");
                }
                else
                {
                    Console.WriteLine($"{quantity * 2.70:f2}");
                }
            }
            else if (fruit == "pineapple" && isValid == true)
            {
                if (isWeekend == true)
                {
                    Console.WriteLine($"{quantity * 5.6:f2}");
                }
                else
                {
                    Console.WriteLine($"{quantity * 5.5:f2}");
                }
            }
            else if (fruit == "grapes" && isValid == true)
            {
                if (isWeekend == true)
                {
                    Console.WriteLine($"{quantity * 4.20:f2}");
                }
                else
                {
                    Console.WriteLine($"{quantity * 3.85:f2}");
                }
            }
            else
            {
                isValid = false;
            }
            if (isValid == false)
            {
                Console.WriteLine("error");
            }
        }
    }
}