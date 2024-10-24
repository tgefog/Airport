using System.Text;

namespace _04._Pass_Reset
{
    /*
Siiceercaroetavm!:?:ahsott.:i:nstupmomceqr
TakeOdd
Cut 15 3
Substitute :: -
Substitute | ^
Done

up8rgoyg3r1atmlmpiunagt!-irs7!1fgulnnnqy
TakeOdd
Cut 18 2
Substitute ! ***
Substitute ? .!.
Done
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string rawPassword = Console.ReadLine();
            StringBuilder password = new StringBuilder(rawPassword);

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Done")
            {
                string[] arguments = input.Split();
                switch (arguments[0])
                {
                    case "Cut":
                        int startIndex = int.Parse(arguments[1]);
                        int length = int.Parse(arguments[2]);
                        password = Cut(password, startIndex, length);
                        break;
                    case "TakeOdd":
                        password = TakeOdd(password);
                        break;
                    case "Substitute":
                        string substing = arguments[1];
                        string substitute = arguments[2];
                        password = Substite(password, substing, substitute);
                        break;
                }
            }
            Console.WriteLine($"Your password is: {password}");
        }

        private static StringBuilder Substite(StringBuilder password, string substing, string substitute)
        {
            if (password.ToString().Contains(substing))
            {
                password = password.Replace(substing, substitute);
                Console.WriteLine(password);
            }
            else
            {
                Console.WriteLine("Nothing to replace!");
            }
            return password;
        }

        private static StringBuilder Cut(StringBuilder password, int startIndex, int length)
        {
            password = password.Remove(startIndex, length);
            Console.WriteLine(password);
            return password;
        }

        private static StringBuilder TakeOdd(StringBuilder password)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 1; i < password.Length; i += 2)
            {
                result.Append(password[i]);
            }
            Console.WriteLine(result);
            return result;
        }
    }
}