namespace Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputSongs = Console.ReadLine().Split(", ");
            Queue<string> songs = new Queue<string>(inputSongs);
            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "Play")
                {
                    if (songs.Any())
                    {
                        songs.Dequeue();

                    }
                    if (songs.Count == 0)
                    {
                        Console.WriteLine("No more songs!");
                        break;
                    }


                }
                else if (command[0] == "Add")
                {
                    string songName = String.Join(" ", command.Skip(1));
                    if (songs.Contains(songName))
                    {
                        Console.WriteLine($"{songName} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(songName);
                    }
                }
                else if (command[0] == "Show")
                {
                    Console.WriteLine($"{string.Join(", ", songs)}");
                }
            }
        }
    }
}