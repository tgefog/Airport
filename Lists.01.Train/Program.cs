namespace Lists._01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxWagonCapacity = int.Parse(Console.ReadLine());
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split(" ");
                if (arguments[0] == "Add")
                {
                    wagons.Add(int.Parse(arguments[1]));
                }
                else
                {
                    int newPassengers = int.Parse(arguments[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + newPassengers <= maxWagonCapacity)
                        {
                            wagons[i] += newPassengers;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}