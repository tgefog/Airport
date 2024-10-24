﻿using System;
namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isFound = false;
            for (int i = 0; i < array.Length; i++)
            {
                int leftSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += array[j];
                }
                int rightSum = 0;
                for (int k = array.Length - 1; k > i; k--)
                {
                    rightSum += array[k];
                }
                if (leftSum == rightSum && !isFound)
                {
                    Console.WriteLine(i);
                    isFound = true;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}