using System.Collections;

namespace BasicQueueOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] values = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int valuesToPush = values[0];//5
            int valuesToPop = values[1];//2
            int lookUpValve = values[2];//13

            Queue<int> stack = new Queue<int>();

            for (int i = 0; i < valuesToPush; i++)
            {
                stack.Enqueue(input[i]);
            }

            while (stack.Count > 0 && valuesToPop > 0)
            {
                stack.Dequeue();
                valuesToPop--;
            }
            if (stack.Contains(lookUpValve))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}