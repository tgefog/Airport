using System;

namespace ReadText
{
    internal class ReadText
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "Stop")
            {
                Console.WriteLine(input);
            }
        }
    }
}