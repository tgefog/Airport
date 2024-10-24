using System.Linq;

namespace OffroadChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> initialFuel = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> fuelConsumptionIndex = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> neededFuel = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            List<int> reachedAltitudes = new List<int>();
            int altitudeCount = 0;

            while (initialFuel.Count > 0)
            {
                altitudeCount++;
                int currentFuel = initialFuel.Pop();
                int currentConsumptionIndex = fuelConsumptionIndex.Dequeue();
                int substractedFuel = currentFuel - currentConsumptionIndex;
                int currentNeededFuel = neededFuel.Dequeue();

                if (substractedFuel >= currentNeededFuel)
                {
                    Console.WriteLine($"John has reached: Altitude {altitudeCount}");
                    reachedAltitudes.Add(altitudeCount);
                }
                else
                {
                    Console.WriteLine($"John did not reach: Altitude {altitudeCount}");
                    break;
                }
            }
            if (reachedAltitudes.Count == 4)
            {
                Console.WriteLine("John has reached all the altitudes and managed to reach the top!");
            }
            else if (reachedAltitudes.Count == 0)
            {
                Console.WriteLine("John failed to reach the top.");
                Console.WriteLine("John didn't reach any altitude.");
            }
            else
            {
                Console.WriteLine("John failed to reach the top.");
                Console.WriteLine("Reached altitudes: " + string.Join(", ", reachedAltitudes.ConvertAll(a => "Altitude " + a)));
            }
        }
    }
}