namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
            //Dictionary
            Dictionary<double, int> numbersCount = new Dictionary<double, int>();
            foreach (double number in numbers)
            {
                if (!numbersCount.ContainsKey(number))
                {
                    //no entry with key ==number -> first time seeing this number -> add
                    numbersCount.Add(number, 1);
                }
                else
                {
                    //we have an entry with key==number -> we have already seen the number
                    numbersCount[number]++;
                }
            }
            //number->count seen
            foreach (var entry in numbersCount)
            {
                //entry-> key(number) : value(count seen)
                Console.WriteLine($"{entry.Key} - {entry.Value} times");
            }
        }
    }
}