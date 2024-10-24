using System;
namespace Vowels_Sum
{
    internal class VowelsSum
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int VowelsSum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                switch (text[i])
                {
                    case 'a':
                        VowelsSum++;
                        break;
                    case 'o':
                        VowelsSum += 4;
                        break;
                    case 'e':
                        VowelsSum += 2;
                        break;
                    case 'u':
                        VowelsSum += 5;
                        break;
                    case 'i':
                        VowelsSum += 3;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(VowelsSum);
        }
    }
}