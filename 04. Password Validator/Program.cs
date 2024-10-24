namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool lengthChecked = CheckLength(password);
            bool symbolsChecked = CheckSpecialSymbols(password);
            bool twoDigitsChecked = CheckTwoDigits(password);
            //Invalid password cases
            if (!lengthChecked)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!symbolsChecked)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!twoDigitsChecked)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            //Valid password case
            if (lengthChecked && symbolsChecked && twoDigitsChecked)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool CheckLength(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }
        static bool CheckSpecialSymbols(string password)
        {
            foreach (var symbol in password)
            {
                if (symbol >= 65 && symbol <= 90 ||
                    symbol >= 97 && symbol <= 122 ||
                    symbol >= 48 && symbol <= 57)
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        static bool CheckTwoDigits(string password)
        {
            int count = 0;
            foreach (var symbol in password)
            {
                if (symbol >= 48 && symbol <= 57)
                {
                    count++;
                }
            }
            return count >= 2;
        }
    }
}