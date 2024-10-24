namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                if (IsTopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool IsTopNumber(int num)
        {
            return (IsDivisibleByEight(num) && HasOddNumber(num));
        }

        private static bool HasOddNumber(int num)
        {
            while (num > 0)
            {
                int digit = num % 10; //get digit
                if (digit % 2 == 1)
                {
                    return true;
                }
                num /= 10; //get enxt number
            }
            return false;
        }

        static bool IsDivisibleByEight(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                var digit = num % 10; //get digit
                sum += digit; //sum it
                num /= 10; //get enxt number
            }
            return sum % 8 == 0;
        }
    }
}