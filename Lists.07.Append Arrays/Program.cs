namespace Lists._07.Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);
            List<string> symbols = ExtractSymbols(stringArray);
            Console.WriteLine(string.Join(" ", symbols));
        }

        private static List<string> ExtractSymbols(string[] stringArray)
        {
            List<string> result = new List<string>();
            for (int i = stringArray.Length - 1; i >= 0; i--)
            {
                string[] array = stringArray[i].Split(' ',StringSplitOptions.RemoveEmptyEntries).ToArray();
                result.AddRange(array);
            }
            return result;
        }
    }
}