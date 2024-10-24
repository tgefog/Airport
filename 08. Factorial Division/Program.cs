namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long first = long.Parse(Console.ReadLine());
            long second = long.Parse(Console.ReadLine());
            double result = Factorial(first) / Factorial(second);

            Console.WriteLine($"{result:f2}");
        }
        static double Factorial(long number)
        {
            double result = number;
            for (long i = number - 1; i >= 1; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}