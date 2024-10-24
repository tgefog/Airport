namespace _01._Advertisement_Message
{
    class Advertisement
    {
        public string[] phrases =
        {
            "Excellent product.",
            "Such a great product.",
            "I always use that product.",
            "Best product of its category.",
            "Exceptional product.",
            "I can't live without this product."
        };
        public string[] events =
        {
            "Now I feel good.",
            "I have succeeded with this product.",
            "Makes miracles.I am happy of the results!",
            "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.",
            "I feel great!"
        };

        public string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

        public string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
        public string RandomMessage()
        {
            Random random = new Random();

            int randomIndex = random.Next(phrases.Length);
            string phrase = phrases[randomIndex];

            randomIndex = random.Next(events.Length);
            string @event = events[randomIndex];

            randomIndex = random.Next(authors.Length);
            string author = authors[randomIndex];

            randomIndex = random.Next(cities.Length);
            string city = cities[randomIndex];

            return $"{phrase} {@event} {author} – {city}.";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i < input; i++)
            {
                Advertisement advertisement = new Advertisement();
                Console.WriteLine(advertisement.RandomMessage());
            }
        }
    }
}