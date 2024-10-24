namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(GetMiddleCharacter(input));
        }
        static string GetMiddleCharacter(string input)
        {
            int length = input.Length;
            string result = "";

            if (length % 2 == 1)
            {
                result = input[input.Length / 2].ToString();
            }
            else
            {
                result = input[input.Length / 2 - 1].ToString() + input[input.Length / 2].ToString();
            }
            return result;
        }
    }
}