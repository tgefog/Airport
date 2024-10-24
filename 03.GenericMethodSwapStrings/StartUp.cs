using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethodSwapStrings
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<int> items = new List<int>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                int input = int.Parse(Console.ReadLine());
                items.Add(input);
            }
            int[] indices = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Swap(indices[0], indices[1], items);
            foreach (int item in items)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }
        }
        static void Swap<T>(int firstIndex, int secondIndex, List<T> items)
        {
            (items[secondIndex], items[firstIndex]) = (items[firstIndex], items[secondIndex]);
        }
    }
}
