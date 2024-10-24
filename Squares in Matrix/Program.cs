using System.Drawing;
using System.Xml;

namespace Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            int count = 0; //matrix count
            char[,] matrix = new char[rows, cols];

            for (int row = 0; row <= rows - 1; row++) //all rows from 0 to 2
            {
                char[] symbols = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col <= cols - 1; col++)
                {
                    matrix[row, col] = symbols[col];
                }
            }
            

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    int element = matrix[row, col];
                    bool isEqualRight = element == matrix[row, col + 1];
                    bool isEqualLower = element == matrix[row + 1, col];
                    bool isEqualDiagonal = element == matrix[row + 1, col + 1];
                    if (isEqualRight && isEqualLower && isEqualDiagonal)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}