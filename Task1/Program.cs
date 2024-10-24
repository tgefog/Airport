using System.Text;
using System.Text.RegularExpressions;

namespace Task1
{
    /*
A7ci0
Illusion 1 c
Illusion 4 o
Abjuration
Abracadabra 

TR1GG3R
Necromancy
Illusion 8 m
Illusion 9 n
Abracadabra

SwordMaster
Target Target Target
Abjuration
Necromancy
Alteration master
Abracadabra
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string spellToDecypher = Console.ReadLine();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Abracadabra")
            {
                string[] arguments = input.Split();
                if (arguments[0]== "Abjuration")
                {
                    spellToDecypher = spellToDecypher.ToUpper();
                    Console.WriteLine(spellToDecypher);
                }
                else if (arguments[0] == "Necromancy")
                {
                    spellToDecypher = spellToDecypher.ToLower();
                    Console.WriteLine(spellToDecypher);
                }
                else if (arguments[0] == "Illusion")
                {
                    int index = int.Parse(arguments[1]);
                    char letter = char.Parse(arguments[2]);
                    spellToDecypher = ReplaceCharsAtIndex(spellToDecypher, index, letter);

                }
                else if (arguments[0] == "Divination")
                {
                    string firstSubsting = arguments[1];
                    string secondSubstring = arguments[2];
                    if (spellToDecypher.Contains(firstSubsting))
                    {
                        spellToDecypher = ReplaceAllMatches(spellToDecypher, firstSubsting, secondSubstring);
                        Console.WriteLine(spellToDecypher);
                    }
                }
                else if (arguments[0] == "Alteration")
                {
                    string substringToRemove = arguments[1];
                    spellToDecypher = spellToDecypher.Replace(substringToRemove, "");
                    Console.WriteLine(spellToDecypher);
                }
                else
                {
                    Console.WriteLine("The spell did not work!");
                }
            }
        }

        private static string ReplaceCharsAtIndex(string spellToDecypher, int index, char letter)
        {
            if (index < 0 || index >= spellToDecypher.Length)
            {
                Console.WriteLine("The spell was too weak.");
                return spellToDecypher;
            }
            else
            {
                char[] stringChars = spellToDecypher.ToCharArray();
                stringChars[index] = letter;
                Console.WriteLine("Done!");
                return new string(stringChars);
            }
        }
        private static string ReplaceAllMatches(string spellToDecypher, string firstSubsting, string secondSubstring)
        {
            return Regex.Replace(spellToDecypher, firstSubsting, secondSubstring);
        }
    }
}