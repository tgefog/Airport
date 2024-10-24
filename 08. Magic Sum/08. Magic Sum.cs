using System;
namespace _08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int target = int.Parse(Console.ReadLine());
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == target)
                    {
                        Console.Write($"{array[i]} {array[j]}");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}