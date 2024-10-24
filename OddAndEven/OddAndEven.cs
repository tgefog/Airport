using System;
namespace OddAndEven
{
    internal class OddAndEven
    {
        static void Main(string[] args)
        {
            //1. четем начало и край на интервала от конзолата
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            //2. Пускаме цикъл, който да се изпълнява от 1вото до последното число
            for (int num = first; num <= second; num++)
            {
                int oddSum = 0;
                int evenSum = 0;
                string currentNum = num.ToString();
                //цикъл, който да се изпълнява от първата цифра до последната
                for (int i = 0; i < 6; i++)
                {
                    //правим проверва дали текущата цифра е на нечетна позиция
                    if (i % 2 == 0)//да->добавяме в сума 1
                        evenSum += currentNum[i];
                    else           //ако не -в сума 2
                        oddSum += currentNum[i];
                }
                //проверяваме дали сумите са равни
                if (evenSum == oddSum)
                    //ако са отпечатваме числото
                    Console.Write($"{num} ");
                //ако не, продължаваме
            }
        }
    }
}