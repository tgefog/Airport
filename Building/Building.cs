using System;
namespace Building
{
    internal class Building
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            for (int i = floors; i >= 1; i--)
            {
                string output = "";
                for (int j = 0; j < rooms; j++)
                {
                    if (i == floors)
                    {
                        output = output + $"L{i}{j} ";
                    }
                    else if (i % 2 == 0)
                    {
                        output = output + $"O{i}{j} ";
                    }
                    else
                    {
                        output = output + $"A{i}{j} ";
                    }
                }
                Console.WriteLine(output);
            }
        }
    }
}