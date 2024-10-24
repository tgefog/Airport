using System.Numerics;

namespace Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());//square matrix
            if (size < 3)
            {
                Console.WriteLine(0);
                return;
            }
            int countRemovedKnights = 0;
            char[,] matrix = new char[size, size];
            for (int row = 0; row <= size - 1; row++) //all rows from 0 to 2
            {
                char[] symbols = Console.ReadLine().ToArray();
                for (int col = 0; col <= size - 1; col++)
                {
                    matrix[row, col] = symbols[col];
                }
            }
            while (true)
            {
                int maxAttack = 0;//max attacks from a knight
                int rowMaxAttack = 0; //row of the most attacking knight
                int colMaxAttack = 0; //col of the most attacking knight
                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        char currentElement = matrix[row, col];
                        if (currentElement == 'K')
                        {
                            int countAttackedKnights = CalculateAttackedKnights(row, col, size, matrix);
                            if (countAttackedKnights > maxAttack)//which is the knight with most attacks
                            {
                                maxAttack = countAttackedKnights;
                                rowMaxAttack = row;
                                colMaxAttack = col;
                            }
                        }
                    }
                }
                if (maxAttack == 0)
                {
                    //no attacking knights
                    break;
                }
                else
                {
                    matrix[rowMaxAttack, colMaxAttack] = ' ';//remove knight with most attacks
                    countRemovedKnights++;
                }
            }
            Console.WriteLine(countRemovedKnights);

            static int CalculateAttackedKnights(int row, int col, int size, char[,] matrix)
            {
                int count = 0;
                //2 up 1 right  row -2 col +1 CHECKED
                if (isValid(row - 2, col + 1, size)) //Is the spot where we are going valid
                {
                    if (matrix[row - 2, col + 1] == 'K')
                    {
                        count++;
                    }
                }
                //2 down 1 right row +2 col+1 CHECKED
                if (isValid(row + 2, col + 1, size)) //Is the spot where we are going valid
                {
                    if (matrix[row + 2, col + 1] == 'K')
                    {
                        count++;
                    }
                }
                //2 up 1 left row-2 col-1 CHECKED
                if (isValid(row - 2, col - 1, size)) //Is the spot where we are going valid
                {
                    if (matrix[row - 2, col - 1] == 'K')
                    {
                        count++;
                    }
                }
                //2 down 1 left row+2 col-1 CHECKED
                if (isValid(row + 2, col - 1, size)) //Is the spot where we are going valid
                {
                    if (matrix[row + 2, col - 1] == 'K')
                    {
                        count++;
                    }
                }
                //2 right 1 down row +1 col +2 CHECKED
                if (isValid(row + 1, col + 2, size)) //Is the spot where we are going valid
                {
                    if (matrix[row + 1, col + 2] == 'K')
                    {
                        count++;
                    }
                }
                //2 right 1 up row -1 col +2 CHECKED
                if (isValid(row - 1, col + 2, size)) //Is the spot where we are going valid
                {
                    if (matrix[row - 1, col + 2] == 'K')
                    {
                        count++;
                    }
                }
                //2 left 1 down row+1 col-2 CHECKED
                if (isValid(row + 1, col - 2, size)) //Is the spot where we are going valid
                {
                    if (matrix[row + 1, col - 2] == 'K')
                    {
                        count++;
                    }
                }
                //2 left 1 up row+1 col+2  CHECKED
                if (isValid(row - 1, col - 2, size)) //Is the spot where we are going valid
                {
                    if (matrix[row - 1, col - 2] == 'K')
                    {
                        count++;
                    }
                }
                return count;
            }
            static bool isValid(int row, int col, int size)
            {
                return row >= 0 && row < size && col >= 0 && col < size;
            }
        }


    }
}