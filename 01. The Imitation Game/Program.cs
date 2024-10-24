namespace _01._The_Imitation_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();
            string commands = string.Empty;
            while ((commands = Console.ReadLine()) != "Decode")
            {
                string[] arguments = commands.Split("|");
                string command = arguments[0];
                switch (command)
                {
                    case "Insert":
                        int indexToInsert = int.Parse(arguments[1]);
                        string valueToInsert = arguments[2];
                        encryptedMessage = encryptedMessage.Insert(indexToInsert, valueToInsert);
                        break;
                    case "Move":
                        int lettersToMove = int.Parse(arguments[1]);
                        string temp = encryptedMessage.Substring(0, lettersToMove);
                        encryptedMessage = encryptedMessage.Remove(0, lettersToMove);
                        encryptedMessage = encryptedMessage + temp;
                        break;
                    case "ChangeAll":
                        string stringToBeReplaced = arguments[1];
                        string replacingString = arguments[2];
                        if (encryptedMessage.Contains(stringToBeReplaced))
                        {
                            encryptedMessage = encryptedMessage.Replace(stringToBeReplaced, replacingString);
                        }
                        break;
                }
            }
            Console.WriteLine($"The decrypted message is: {encryptedMessage}");
        }
    }
}