namespace DeliveryBoy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            char[,] field = new char[rows, cols];

            int boyRow = 0;
            int boyCol = 0;

            int boyInitialRow = 0;
            int boyInitialCol = 0;

            for (int row = 0; row < rows; row++)
            {
                string newRow = Console.ReadLine();
                for (int col = 0; col < cols; col++)
                {
                    field[row, col] = newRow[col];
                    if (field[row, col] == 'B')
                    {
                        boyRow = row;
                        boyCol = col;
                        boyInitialRow = row;
                        boyInitialCol = col;
                    }
                }
            }
            bool isOutsideMatrix = false;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "left")
                {
                    if (boyCol == 0)
                    {
                        if (field[boyRow, boyCol] == '-')
                        {
                            field[boyRow, boyCol] = '.';
                        }

                        isOutsideMatrix = true;

                        Console.WriteLine("The delivery is late. Order is canceled.");
                        break;
                    }

                    if (field[boyRow, boyCol - 1] == '*')
                    {
                        continue;
                    }

                    if (field[boyRow, boyCol] != 'R')
                    {
                        field[boyRow, boyCol] = '.';
                    }
                    boyCol--;
                }
                else if (command == "right")
                {
                    if (boyCol == field.GetLength(1) - 1)
                    {
                        if (field[boyRow, boyCol] == '-')
                        {
                            field[boyRow, boyCol] = '.';
                        }

                        isOutsideMatrix = true;

                        Console.WriteLine("The delivery is late. Order is canceled.");
                        break;
                    }

                    if (field[boyRow, boyCol + 1] == '*')
                    {
                        continue;
                    }

                    if (field[boyRow, boyCol] != 'R')
                    {
                        field[boyRow, boyCol] = '.';
                    }
                    boyCol++;
                }
                else if (command == "up")
                {
                    if (boyRow == 0)
                    {
                        if (field[boyRow, boyCol] == '-')
                        {
                            field[boyRow, boyCol] = '.';
                        }

                        isOutsideMatrix = true;

                        Console.WriteLine("The delivery is late. Order is canceled.");
                        break;
                    }

                    if (field[boyRow - 1, boyCol] == '*')
                    {
                        continue;
                    }

                    if (field[boyRow, boyCol] != 'R')
                    {
                        field[boyRow, boyCol] = '.';
                    }
                    boyRow--;
                }
                else if (command == "down")
                {
                    if (boyRow == field.GetLength(0) - 1)
                    {
                        if (field[boyRow, boyCol] == '-')
                        {
                            field[boyRow, boyCol] = '.';
                        }

                        isOutsideMatrix = true;

                        Console.WriteLine("The delivery is late. Order is canceled.");
                        break;
                    }

                    if (field[boyRow + 1, boyCol] == '*')
                    {
                        continue;
                    }

                    if (field[boyRow, boyCol] != 'R')
                    {
                        field[boyRow, boyCol] = '.';
                    }
                    boyRow++;
                }
                if (field[boyRow, boyCol] == 'P')
                {
                    Console.WriteLine("Pizza is collected. 10 minutes for delivery.");
                    field[boyRow, boyCol] = 'R';
                    continue;
                }
                if (field[boyRow, boyCol] == 'A')
                {
                    Console.WriteLine("Pizza is delivered on time! Next order...");
                    field[boyRow, boyCol] = 'P';
                    break;
                }
            }
            if (isOutsideMatrix)
            {
                field[boyInitialRow, boyInitialCol] = ' ';
            }
            else
            {
                field[boyInitialRow, boyInitialCol] = 'B';
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(field[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}