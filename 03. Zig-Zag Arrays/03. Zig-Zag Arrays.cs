using System;
namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrayOne = new int[n];
            int[] arrayTwo = new int[n];
            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine()  //string
                .Split() //string[]
                .Select(int.Parse)//IEnumerable<int>
                .ToArray();
                if (i == 0 || i % 2 == 0)
                {
                    arrayOne[i] = input[0];
                    arrayTwo[i] = input[1];
                }
                else
                {
                    arrayOne[i] = input[1];
                    arrayTwo[i] = input[0];
                }
            }
            for (int i = 0; i < arrayOne.Length; i++)
            {
                Console.Write($"{arrayOne[i]} ");
            }
            Console.WriteLine();
            for (int i = 0; i < arrayTwo.Length; i++)
            {
                Console.Write($"{arrayTwo[i]} ");
            }

        }
    }
}