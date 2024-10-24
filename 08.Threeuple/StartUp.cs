using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threeuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] personTokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] drinkTokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] bankTokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Threeuple<string, string, string> person = new Threeuple<string, string, string>($"{personTokens[0]} {personTokens[1]}", personTokens[2], string.Join(" ",personTokens[3..]));
            Threeuple<string, int, bool> drinks = new Threeuple<string, int, bool>(drinkTokens[0], int.Parse(drinkTokens[1]), drinkTokens[2] == "drunk");
            Threeuple<string, double, string> bank = new Threeuple<string, double, string>(bankTokens[0], double.Parse(bankTokens[1]), bankTokens[2]);
            Console.WriteLine(person);
            Console.WriteLine(drinks);
            Console.WriteLine(bank);
        }
    }
}
