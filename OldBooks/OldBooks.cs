using System;
namespace OldBooks
{
    internal class OldBooks
    {
        static void Main(string[] args)
        {
            //1. Четем от конзолата заглавието на любимата книга
            string favBook = Console.ReadLine();
            //брой проверени книги
            int counter = 0;
            string input;
            //2. Създаваме While цикъл, който да се изпълнява докато не проверим всички книги
            //Четем от конзолата заглавие на текуща книга
            while ((input = Console.ReadLine()) != "No More Books")
            {
                //проверяваме дали това е любимата книга
                if (input == favBook)
                {
                    //ако е-> спираме цикъла
                    break;
                }
                //ако не е ->увеличаваме брояча на книгите, които сме проверили с 1
                counter++;
            }
            //3.Извеждаме изхода на конзолата
            //ако сме намерили книгата : 
            if (input == favBook)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            //ако не сме намерили книгата :
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}