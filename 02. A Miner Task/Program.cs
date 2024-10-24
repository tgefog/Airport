namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, uint> resourcesMap = new Dictionary<string, uint>();
            string resource;
            uint quantity;

            while ((resource = Console.ReadLine()) != "stop")
            {
                quantity = uint.Parse(Console.ReadLine());
                if (!resourcesMap.ContainsKey(resource))
                {
                    resourcesMap.Add(resource, 0);
                }
                resourcesMap[resource] += quantity;
            }
            foreach (KeyValuePair<string, uint> pair in resourcesMap)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}