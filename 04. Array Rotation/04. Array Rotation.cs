using System;
namespace _04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().ToArray();
            int n = int.Parse(Console.ReadLine());
            for (int j = 0; j < n; j++)
            {
                var end = array[0];
                for (var i = 0; i < array.Length - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                array[array.Length - 1] = end;
            }
            Console.WriteLine(string.Join(" ", array));

        }
    }
}