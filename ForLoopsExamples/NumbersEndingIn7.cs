using System;
namespace ForLoopsExercises
{
    internal class NumbersEndingIn7
    {
        static void Main(string[] args)
        {
            //Проверява всички числа от 1 до 1000, които завършват на 7, като циклим от 7 до 997 и увеличаваме с 10
            for (int i = 7; i <= 997; i+=10)
            {
                //отпечатваме числото
                    Console.WriteLine(i);
            }
        }
    }
}