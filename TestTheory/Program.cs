using System.Runtime.InteropServices;

namespace TestTheory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greet = "Hello World";
            Console.WriteLine(greet.Substring(3, 4));
        }
        public static void printText(string text)
        {
            Console.WriteLine("I love" + text);
        }
    }
}