using System;
namespace _04._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inputs
            int n = int.Parse(Console.ReadLine()); //number of lines
            char input;//latin letters (will be called n times)
            int sum = 0;
            //body
            for (int i = 0; i < n; i++)
            {
                input = char.Parse(Console.ReadLine()); //read input as char
                sum += (int)input; //get int value of the char
            }
            //output
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}