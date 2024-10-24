using System;
namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //poke power
            int m = int.Parse(Console.ReadLine()); //distance between targets
            int y = int.Parse(Console.ReadLine()); //exhaustion factor
            int initialN = n;
            int count = 0;
            bool equal = false;

            while (n > m)
            {
                n -= m;
                count++;
                if (n == initialN * 0.5)
                {
                    equal = true;
                }
            }
            if (equal)
            {
                n = n / y;
            }
            Console.WriteLine(n);
            Console.WriteLine(count);
        }
    }
}