using System;
namespace _05._Print_Part_of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inputs
            int startIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());
            //body
            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.Write($"{(char)i} "); 
            }
        }
    }
}