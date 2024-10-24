using System;
namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inputs
            int n = int.Parse(Console.ReadLine()); //number of people
            int p = int.Parse(Console.ReadLine()); //elevator capacity

            //Body
            int courses = (int)Math.Ceiling((double)n / p);
            //Output
            Console.WriteLine(courses);
        }
    }
}