using System;
namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inputs 
            int n = int.Parse(Console.ReadLine()); //how many times we will pour in the tank
            int litersInput; //how many litres will be poured in the tank
            int currentCapacity = 0; //current capacity
            int maxCapacity = 255; //max tank capacity

            //body
            for (int i = 0; i < n; i++)
            {
                litersInput = int.Parse(Console.ReadLine()); //read litres value from console
                if ((maxCapacity - currentCapacity) >= litersInput)//check if there is enough capacity for the litres we are going to pour
                    currentCapacity += litersInput; //if yes -> increase current capacity
                else
                    Console.WriteLine("Insufficient capacity!"); //if not -> print "Insufficient capacity!" message
            }

            //output
            Console.WriteLine(currentCapacity); //print the current litres in the tank
        }
    }
}