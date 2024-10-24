using System;

namespace ProjectCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());
            while (projects < 0 || projects > 100)
            {
                Console.WriteLine("Invalid entry");
                Console.WriteLine("Enter a new number");
                projects = int.Parse(Console.ReadLine());
            }
            int hours = projects * 3;
            Console.WriteLine("The architect " + name + " will need " + hours + " hours to complete " + projects + " project/s.");
        }
    }
}