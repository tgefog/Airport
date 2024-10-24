using System;
namespace _01.Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            string result = "";
            if (age >= 66)
            {
                result = "elder";
            }
            else if (age >= 20)
            {
                result = "adult";
            }
            else if (age >= 14)
            {
                result = "teenager";
            }
            else if (age >= 3)
            {
                result = "child";
            }
            else
            {
                result = "baby";
            }
            Console.WriteLine(result);
        }
    }
}