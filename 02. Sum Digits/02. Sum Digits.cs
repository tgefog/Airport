﻿using System;
namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int m;
            while (number > 0)
            {
                m = number % 10;
                sum=sum + m;
                number= number / 10;
            }
            Console.WriteLine(sum);
        }
    }
}