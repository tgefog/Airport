namespace _04._Soft_Uni_Parking
{
    class User
    {

        public string Username { get; set; }
        public string LicensePlateNumber { get; set; }
        public User(string username, string licensePlateNumber)
        {
            Username = username;
            LicensePlateNumber = licensePlateNumber;
        }
        public override string ToString()
        {
            return $"{Username} => {LicensePlateNumber}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, User> database = new Dictionary<string, User>();

            int numberOfCommands = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberOfCommands; i++)
            {
                string[] arguments = Console.ReadLine().Split();
                string command = arguments[0];
                string userName = arguments[1];

                switch (command)
                {
                    case "register":
                        string licensePlateNumber = arguments[2];
                        User newUser = new User(userName, licensePlateNumber);
                        if (!database.ContainsKey(newUser.Username))
                        {
                            database.Add(newUser.Username, newUser);
                            Console.WriteLine($"{newUser.Username} registered {newUser.LicensePlateNumber} successfully");
                        }
                        else
                        {
                            User foundUser = database[newUser.Username];
                            Console.WriteLine($"ERROR: already registered with plate number {foundUser.LicensePlateNumber}");
                        }
                        break;
                    case "unregister":
                        if (database.ContainsKey(userName))
                        {
                            database.Remove(userName);
                            Console.WriteLine($"{userName} unregistered successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: user {userName} not found");
                        }
                        break;
                }
            }
            foreach (User user in database.Values)
            {
                Console.WriteLine(user);
            }
        }
    }
}