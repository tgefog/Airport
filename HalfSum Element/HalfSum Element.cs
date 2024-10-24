using System;
namespace HalfSum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Четем n числа от конзолата
            int n = int.Parse(Console.ReadLine());
            //инициализираме променливи за сума и най-голямо число
            int maxNumber = int.MinValue;
            int sum = 0;
            int num;
            //2. Създаваме цикъл, който се изпълнява от 1 до N
            for (int i = 1; i <= n; i++)
            {
                //четем всички числа
                num = int.Parse(Console.ReadLine());
                //добавяме го към сумата на всички числа
                sum += num;
                //проверяваме дали то е най-голямото до момента
                if (num > maxNumber)
                {
                    maxNumber = num;
                }
            }
            //3. Проверяваме дали най-голямото число е равно на сумата на всички останали числа
            sum -= maxNumber;
            if (maxNumber == sum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(maxNumber - sum)}");
            }
        }
    }
}