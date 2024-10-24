using System;

namespace Lists._11.Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<string> input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            //char[] chars;
            List<int> summedNumbers = new List<int>();
            List<int> tempList = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                tempList = GetIntArray(numbers[i]);
                summedNumbers.Add(tempList.Sum());
                tempList.RemoveRange(0, tempList.Count - 1);
            }
            Console.WriteLine(String.Join(" ", summedNumbers));
            Console.WriteLine(String.Join("", input));

            for (int i = 0; i < summedNumbers.Count; i++)
            {
                int correctIndex = 0;
                if (summedNumbers[i] > input.Count)
                {
                    correctIndex = summedNumbers[i] % input.Count;
                }
                else
                {
                    correctIndex = summedNumbers[i];
                }
                input.RemoveAt(correctIndex);
            }
            Console.WriteLine(String.Join(" ", input));
        }
        static List<int> GetIntArray(int num)
        {
            List<int> listOfInts = new List<int>();
            while (num > 0)
            {
                listOfInts.Add(num % 10);
                num = num / 10;
            }
            listOfInts.Reverse();
            return listOfInts;
        }
    }
}