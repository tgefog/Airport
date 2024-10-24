namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            if (firstChar > secondChar)
            {
                char swapTemp = firstChar;
                firstChar = secondChar;
                secondChar = swapTemp;
            }
            PrintBetween(firstChar, secondChar);
        }
        private static void PrintBetween(char first, char second)
        {
            for (int i = first + 1; i < second; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}