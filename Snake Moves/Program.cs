namespace Snake_Moves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            char[,] matrix = new char[rows, cols];

            string snake = Console.ReadLine();
            int counter = 0;
            var snakeQueue = new Queue<char>();
            int maxCapacity = rows * cols;

            for (int i = 0; i < snake.Length; i++)
            {
                snakeQueue.Enqueue(snake[i]);
                counter++;

                if (counter == maxCapacity)
                {
                    break;
                }
                if (i == snake.Length - 1)
                {
                    i = -1;
                }
            }

            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        matrix[row, col] = snakeQueue.Dequeue();
                    }
                }
                else if (row % 2 != 0)
                {
                    for (int k = cols - 1; k > -1; k--)
                    {
                        matrix[row, k] = snakeQueue.Dequeue();
                    }
                }

            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0}", matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}