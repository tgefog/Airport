using System;
namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            //Turn username into char array so it can be reversed
            char[] charArray = username.ToCharArray();
            Array.Reverse(charArray);
            //set password to the already reversed char array
            string password = new string(charArray);

            for (int i = 0; i < 4; i++)
            {
                string attempt=Console.ReadLine();
                if (attempt==password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else if (i==3 && attempt!=password)
                {
                    Console.WriteLine($"User {username} blocked!");
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
        }
    }
}