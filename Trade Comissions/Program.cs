using System;
namespace Trade_Comissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Входна информация
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double comission = 0;
            //2.Валидация на входни данни
            bool validInput = false;
            if (sales > 0 && (city == "Sofia" || city == "Varna" || city == "Plovdiv"))
            {
                validInput = true;
            }
            else
            {
                validInput = false;
            }
            if (validInput == false)
            {
                Console.WriteLine("error");
            }
            else
            //3.Основно действие(Проверка за град и стойност на комисионна спрямо продажбите)
            {
                if (city == "Sofia")
                {
                    if (sales <= 500)
                    {
                        comission = sales * 0.05;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        comission = sales * 0.07;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        comission = sales * 0.08;
                    }
                    else
                    {
                        comission = sales * 0.12;
                    }
                }
                else if (city == "Varna")
                {
                    if (sales <= 500)
                    {
                        comission = sales * 0.045;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        comission = sales * 0.075;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        comission = sales * 0.10;
                    }
                    else
                    {
                        comission = sales * 0.13;
                    }
                }
                else
                {
                    if (sales <= 500)
                    {
                        comission = sales * 0.055;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        comission = sales * 0.08;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        comission = sales * 0.12;
                    }
                    else
                    {
                        comission = sales * 0.145;
                    }
                }
                Console.WriteLine($"{comission:f2}");
            }
        }
    }
}