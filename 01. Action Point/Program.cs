namespace _01._Action_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> print = (string[] strings) =>
            {
                foreach (string s in strings)
                {
                    Console.WriteLine(s);
                }
            };
            string[] strings = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            print(strings);
        }
    }
}