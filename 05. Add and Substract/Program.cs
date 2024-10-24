namespace _05._Add_and_Substract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber=int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int sum = SumofTwoNumbers(firstNumber, secondNumber);
            int result = SubstractNumber(sum,thirdNumber);

            Console.WriteLine(result);
        }
        static int SumofTwoNumbers(int a, int b)
        {
            return a + b;
        }
        static int SubstractNumber(int a, int b)
        {
            return a - b;
        }
    }
}