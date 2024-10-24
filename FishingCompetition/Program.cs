namespace FishingCompetition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] fishingArea = new char[n, n];
            int boatRow = 0;
            int boatCol = 0;
            int foodCollected = 0;
            bool shipCrashed = false;
            for (int row = 0; row < n; row++)
            {
                string newRow = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    fishingArea[row, col] = newRow[col];
                    if (fishingArea[row, col] == 'S')
                    {
                        boatRow = row;
                        boatCol = col;
                        fishingArea[boatRow, boatCol] = '-';
                    }
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "collect the nets")
            {
                int newRow = boatRow;
                int newCol = boatCol;

                if (command == "up")
                    newRow = (boatRow - 1 + n) % n;
                else if (command == "down")
                    newRow = (boatRow + 1) % n;
                else if (command == "left")
                    newCol = (boatCol - 1 + n) % n;
                else if (command == "right")
                    newCol = (boatCol + 1) % n;

                if (fishingArea[newRow, newCol] == 'W')
                {
                    boatRow = newRow;
                    boatCol = newCol;
                    shipCrashed = true;
                    break;
                }
                else if (Char.IsNumber(fishingArea[newRow, newCol]))
                {
                    int food = int.Parse(fishingArea[newRow, newCol].ToString());
                    foodCollected += food;
                    fishingArea[newRow, newCol] = '-';
                }

                boatRow = newRow;
                boatCol = newCol;
            }

            fishingArea[boatRow, boatCol] = 'S';
            if (shipCrashed)
            {
                Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{boatRow},{boatCol}]");
            }
            else
            {
                if (foodCollected >= 20)
                {
                    Console.WriteLine("Success! You managed to reach the quota!");
                }
                else
                {
                    Console.WriteLine($"You didn't catch enough fish and didn't reach the quota! You need {20 - foodCollected} tons of fish more.");
                }
                if (foodCollected > 0)
                {
                    Console.WriteLine($"Amount of fish caught: {foodCollected} tons.");
                }
                PrintFishingArea(fishingArea);
            }
        }
        static void PrintFishingArea(char[,] fishingArea)
        {
            for (int row = 0; row < fishingArea.GetLength(0); row++)
            {
                for (int col = 0; col < fishingArea.GetLength(1); col++)
                {
                    Console.Write(fishingArea[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}