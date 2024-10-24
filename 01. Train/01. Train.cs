using System;
namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int people;
            int total = 0;
            int[] wagon = new int[n];
            for (int i = 0; i < n; i++)
            {
                people = int.Parse(Console.ReadLine());
                wagon[i] = people;
                total += people;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(wagon[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(total);
        }
    }
}