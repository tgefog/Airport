using System;

namespace Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bookPages = int.Parse(Console.ReadLine());
            while (bookPages < 1 || bookPages > 1000)
            {
                Console.WriteLine("Invalid entry");
                Console.WriteLine("Enter a new number");
                bookPages = int.Parse(Console.ReadLine());
            }
            int pagesPerHour = int.Parse(Console.ReadLine());
            while (pagesPerHour < 1 || pagesPerHour > 1000)
            {
                Console.WriteLine("Invalid entry");
                Console.WriteLine("Enter a new number");
                pagesPerHour = int.Parse(Console.ReadLine());
            }
            int readingDeadline = int.Parse(Console.ReadLine());
            while (readingDeadline < 1 || readingDeadline > 1000)
            {
                Console.WriteLine("Invalid entry");
                Console.WriteLine("Enter a new number");
                readingDeadline = int.Parse(Console.ReadLine());
            }
            int totalReadingTime = bookPages / pagesPerHour;
            int hours = totalReadingTime / readingDeadline;
            Console.WriteLine(hours);
        }
    }
}