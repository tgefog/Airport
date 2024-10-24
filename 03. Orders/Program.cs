namespace _03._Orders
{
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public Product(string name, decimal price, decimal quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public void Update(decimal price, decimal quantity)
        {
            Price = price;
            Quantity += quantity;
        }
        public override string ToString()
        {
            return $"{Name} -> {Price * Quantity:f2}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>();
            string product;

            while ((product = Console.ReadLine()) != "buy")
            {
                string[] arguments = product.Split();
                string name = arguments[0];
                decimal price = decimal.Parse(arguments[1]);
                decimal quantity = decimal.Parse(arguments[2]);

                Product newProduct = new Product(name, price, quantity);

                if (!products.ContainsKey(newProduct.Name))
                {
                    products.Add(newProduct.Name, newProduct);
                }
                else
                {
                    products[product].Update(newProduct.Price, newProduct.Quantity);
                }
            }
            foreach (KeyValuePair<string,Product> pair in products)
            {
                Console.WriteLine(pair.Value);
            }
        }
    }
}