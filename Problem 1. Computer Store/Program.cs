namespace Problem_1._Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            double price;
            double sumNoTax = 0;
            double sumTax = 0;
            double taxes = 0;
            while (true)
            {
                input = Console.ReadLine();
                if (input == "special" || input == "regular")
                {
                    break;
                }

                price = double.Parse(input);
                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }
                sumNoTax += price;
            }

            taxes = sumNoTax * 0.2;
            sumTax = taxes + sumNoTax;
            if (sumNoTax == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }
            else
            {
                switch (input)
                {
                    case "special":
                        sumTax = sumTax - 0.1 * sumTax;
                        Console.WriteLine("Congratulations you've just bought a new computer!");
                        Console.WriteLine($"Price without taxes: {sumNoTax:f2}$");
                        Console.WriteLine($"Taxes: {taxes:f2}$");
                        Console.WriteLine("-----------");
                        Console.WriteLine($"Total price: {sumTax:f2}$");
                        break;
                    case "regular":
                        Console.WriteLine("Congratulations you've just bought a new computer!");
                        Console.WriteLine($"Price without taxes: {sumNoTax:f2}$");
                        Console.WriteLine($"Taxes: {taxes:f2}$");
                        Console.WriteLine("-----------");
                        Console.WriteLine($"Total price: {sumTax:f2}$");
                        break;
                }
            }
        }
    }
}