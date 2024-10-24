namespace Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine()); //matrix size: columns=rows
            int[,] matrix = new int[size, size];
            for (int row = 0; row < size; row++) //all rows from 0 to 2
            {
                int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }
            int primaryDiagonal = 0; //row=col

            int secondaryDiagonal = 0; //col=size-1-row
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    int element = matrix[row, col]; //current element
                    if (row == col)
                    {
                        primaryDiagonal += element; //element is on primary diagonal
                    }
                    if (col == size - 1 - row)//not using else because one element can be part of both diagonals
                    {
                        secondaryDiagonal += element; //element is on secondary diagonal
                    }
                }
            }
            Console.WriteLine(Math.Abs(primaryDiagonal - secondaryDiagonal));
        }
    }
}