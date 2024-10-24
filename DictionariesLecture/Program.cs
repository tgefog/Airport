namespace DictionariesLecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> Product = new Dictionary<string, double>();
            //Way 1: Add entry in dictionary
            Product.Add("Banana", 2.30);
            Product.Add("Carrot", 4.90);
            //Way 2: Add entry in dictionary
            Product["Tomato"] = 4.50;
            Console.WriteLine(Product["Banana"]);
            Product.Add("Grape", 3.50);
            Product.Remove("Grape");

            Console.WriteLine(Product.ContainsKey("Cucumber"));
            Console.WriteLine(Product.ContainsKey("Banana"));

            //"Banana" -> 2.30
            //"Carrot" -> 4.90
            //"Tomato" -> 4.50

            //ascending by key
            Product.OrderBy(pair => pair.Key);
            //"Banana" -> 2.30
            //"Carrot" -> 4.90
            //"Tomato" -> 4.50

            //descending by key
            Product.OrderByDescending(pair => pair.Key);
            //"Tomato" -> 4.50
            //"Carrot" -> 4.90
            //"Banana" -> 2.30

            //ascending by value
            Product.OrderBy(pair => pair.Value);
            //"Banana" -> 2.30
            //"Tomato" -> 4.50
            //"Carrot" -> 4.90

            //descending by value
            Product.OrderByDescending(pair => pair.Value);
            //"Carrot" -> 4.90
            //"Tomato" -> 4.50
            //"Banana" -> 2.30

            //double sort
            Product.OrderByDescending(pair => pair.Value).ThenBy(pair => pair.Key);
        }
    }
}