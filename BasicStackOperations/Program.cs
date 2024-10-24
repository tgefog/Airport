namespace BasicStackOperations
{
    /*
5 2 13
1 13 45 32 4
    
4 1 666
420 69 13 666

3 3 90
90 90 90
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] values = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int valuesToPush = values[0];//5
            int valuesToPop = values[1];//2
            int lookUpValve = values[2];//13

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < valuesToPush; i++)
            {
                stack.Push(input[i]);
            }

            while (stack.Count > 0 && valuesToPop > 0)
            {
                stack.Pop();
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