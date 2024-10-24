namespace Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            int maxSum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row <= rows - 1; row++) //all rows from 0 to 2
            {
                int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col <= cols - 1; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    var newSquireSum =
                        matrix[row, col] +
                        matrix[row + 1, col] +
                        matrix[row + 2, col] +
                        matrix[row, col + 1] +
                        matrix[row + 1, col + 1] +
                        matrix[row + 2, col + 1]+
                        matrix[row, col + 2] +
                        matrix[row + 1, col + 2] +
                        matrix[row + 2, col + 2];
                    if (newSquireSum > maxSum)
                    {
                        maxSum = newSquireSum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{matrix[maxRow, maxCol]} {matrix[maxRow, maxCol + 1]} {matrix[maxRow, maxCol + 2]}");
            Console.WriteLine($"{matrix[maxRow + 1, maxCol]} {matrix[maxRow + 1, maxCol + 1]} {matrix[maxRow + 1, maxCol + 2]}");
            Console.WriteLine($"{matrix[maxRow + 2, maxCol]} {matrix[maxRow + 2, maxCol + 1]} {matrix[maxRow + 2, maxCol + 2]}");
        }
    }
}