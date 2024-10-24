using System;
using System.Security.Cryptography.X509Certificates;

namespace Lists._02.Change_List
{
    internal class Program
    {
        static void Main()
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string commands;
            while ((commands = Console.ReadLine()) != "end")
            {
                string[] arguments = commands.Split();
                int index;

                switch (arguments[0])
                {
                    case "Insert":
                        int item = int.Parse(arguments[1]);
                        index = int.Parse(arguments[2]);
                        list.Insert(index, item);
                        break;
                    case "Delete":
                        item = int.Parse(arguments[1]);
                        list.Remove(item);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}