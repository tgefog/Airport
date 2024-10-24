using System;

namespace Operation_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Въвеждаме 2 цели числа и оператор за мат.операция(+,-,*,/,%)
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            string action = Console.ReadLine();
            double result = 0;
            string evenOrNot = "odd";
            //При +,-,* -> резултат+ четен или не
            if (action == "+")
            {
                result = num1 + num2;
                if (result % 2 == 0)
                {
                    evenOrNot = "even";
                }
                Console.WriteLine($"{num1} + {num2} = {result} - {evenOrNot}");
            }
            else if (action == "-")
            {
                result = num1 - num2;
                if (result % 2 == 0)
                {
                    evenOrNot = "even";
                }
                Console.WriteLine($"{num1} - {num2} = {result} - {evenOrNot}");
            }
            else if (action == "*")
            {
                result = num1 * num2;
                if (result % 2 == 0)
                {
                    evenOrNot = "even";
                }
                Console.WriteLine($"{num1} * {num2} = {result} - {evenOrNot}");
            }
            //При / -> резултат
            if (action == "/" && num2 != 0)
            {
                result = num1 / num2;
                Console.WriteLine($"{num1} / {num2} = {result:f2}");
            }
            else if (action == "/" && num2 == 0)
            //Ако делителя е 0, специално съобщение
            {
                Console.WriteLine($"Cannot divide {num1} by zero");
            }
            //При % -> остатъка
            if (action == "%" && num2 != 0)
            {
                result = num1 % num2;
                Console.WriteLine($"{num1} % {num2} = {result}");
            }
            else if (action == "%" && num2 == 0)
            //Ако делителя е 0, специално съобщение
            {
                Console.WriteLine($"Cannot divide {num1} by zero");
            }
        }
    }
}