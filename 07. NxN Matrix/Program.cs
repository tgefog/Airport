namespace _07._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(ReturnMatrix(n));
        }
        static string ReturnMatrix(int n)
        {
            string result = "";
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result += $"{n} ";
                }
                result += "\n";
            }
            return result;
        }
    }
}