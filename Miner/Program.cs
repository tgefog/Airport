using System.Security.AccessControl;

namespace Miner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());//square matrix
            string[] directions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //up right right up rught//left right up down
            char[,] matrix = new char[size, size];
            int currentRow = 0;
            int currentCol = 0;
            int countCoal = 0;
            for (int row = 0; row <= size - 1; row++) //all rows from 0 to 2
            {
                char[] symbols = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col <= size - 1; col++)
                {
                    matrix[row, col] = symbols[col];
                    if (symbols[col] == 's')
                    {
                        currentRow = row;
                        currentCol = col;
                    }
                    else if (symbols[col] == 'c')
                    {
                        countCoal++;
                    }
                }
            }
            foreach (string direction in directions)
            {
                switch (direction)
                {
                    case "left":
                        //col-1

                        if (currentCol - 1 >= 0 && currentCol - 1 <= size - 1)//validate place where we will go
                        {
                            //move
                            currentCol--;
                            //check where we went
                            char currentElement = matrix[currentRow, currentCol];
                            if (currentElement == 'e')
                            {
                                //break cycle;
                                Console.WriteLine($"Game over! ({currentRow}, {currentCol})");

                                return;
                            }
                            else if (currentElement == 'c')
                            {
                                //we take out one coal
                                matrix[currentRow, currentCol] = '*';
                                countCoal--;
                                if (countCoal == 0)
                                {
                                    Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                                    return;
                                }
                            }
                        }
                        break;
                    case "right":
                        //col+1
                        if (currentCol + 1 <= size - 1)//validate place where we will go
                        {
                            currentCol++;
                            //check where we went
                            char currentElement = matrix[currentRow, currentCol];
                            if (currentElement == 'e')
                            {
                                //break cycle;
                                Console.WriteLine($"Game over! ({currentRow}, {currentCol})");

                                return;
                            }
                            else if (currentElement == 'c')
                            {
                                //we take out one coal
                                matrix[currentRow, currentCol] = '*';
                                countCoal--;
                                if (countCoal == 0)
                                {
                                    Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                                    return;
                                }
                            }
                        }
                        break;
                    case "up":
                        //row-1
                        if (currentRow - 1 >= 0 && currentRow - 1 <= size - 1)
                        {
                            currentRow--;
                            //check where we went
                            char currentElement = matrix[currentRow, currentCol];
                            if (currentElement == 'e')
                            {
                                //break cycle;
                                Console.WriteLine($"Game over! ({currentRow}, {currentCol})");

                                return;
                            }
                            else if (currentElement == 'c')
                            {
                                //we take out one coal
                                matrix[currentRow, currentCol] = '*';
                                countCoal--;
                                if (countCoal == 0)
                                {
                                    Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                                    return;
                                }
                            }
                        }
                        break;
                    case "down":
                        if (currentRow + 1 <= size - 1)
                        {
                            currentRow++;
                            //check where we went
                            char currentElement = matrix[currentRow, currentCol];
                            if (currentElement == 'e')
                            {
                                //break cycle;
                                Console.WriteLine($"Game over! ({currentRow}, {currentCol})");

                                return;
                            }
                            else if (currentElement == 'c')
                            {
                                //we take out one coal
                                matrix[currentRow, currentCol] = '*';
                                countCoal--;
                                if (countCoal == 0)
                                {
                                    Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                                    return;
                                }
                            }
                        }
                        //row+1
                        break;


                }
            }
            Console.WriteLine($"{countCoal} coals left. ({currentRow}, {currentCol})");
        }
    }
}