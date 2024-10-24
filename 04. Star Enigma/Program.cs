using System.Text;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    class Message
    {
        public Message(string planetName, uint population, string attackType, uint soldierCount)
        {
            PlanetName = planetName;
            Population = population;
            AttackType = attackType;
            SoldierCount = soldierCount;
        }
        public string PlanetName { get; set; }
        public uint Population { get; set; }
        public string AttackType { get; set; }
        public uint SoldierCount { get; set; }
    }

    internal class Program
    {
        static void Main()
        {
            List<Message> messages = new List<Message>();

            int messagesCount = int.Parse(Console.ReadLine());

            string starPattern = @"[SsTtAaRr]";
            string messagePattern = @"\@(?<planet>[A-Za-z]+)[^\@\-\!\:\>]*\:(?<population>\d+)[^\@\-\!\:\>]*\!(?<type>A|D)\![^\@\-\!\:\>]*\-\>[^\@\-\!\:\>]*?(?<soldiers>\d+)[^\@\-\!\:\>]*";

            for (int i = 0; i < messagesCount; i++)
            {
                string encryptedMessage = Console.ReadLine();

                int starDecryption = Regex.Matches(encryptedMessage, starPattern).Count;

                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < encryptedMessage.Length; j++)
                {
                    sb.Append((char)(encryptedMessage[j] - starDecryption));
                }

                string decryptedMessage = sb.ToString();

                var match = Regex.Match(decryptedMessage, messagePattern);
                if (Regex.IsMatch(decryptedMessage, messagePattern) == false)
                {
                    continue;
                }

                string planetName = match.Groups["planet"].Value;
                uint population = uint.Parse(match.Groups["population"].Value);
                string attackType = match.Groups["type"].Value;
                uint soldierCount = uint.Parse(match.Groups["soldiers"].Value);

                Message message = new Message(planetName, population, attackType, soldierCount);

                messages.Add(message);
            }

            var planets = messages.Where(m => m.AttackType == "A")
                .OrderBy(m => m.PlanetName)
                .ToList();

            Console.WriteLine($"Attacked planets: {planets.Count}");
            planets.ForEach(m => Console.WriteLine($"-> {m.PlanetName}"));

            planets = messages.Where(m => m.AttackType == "D")
                .OrderBy(m => m.PlanetName)
                .ToList();

            Console.WriteLine($"Destroyed planets: {planets.Count}");
            planets.ForEach(m => Console.WriteLine($"-> {m.PlanetName}"));
        }
    }
}