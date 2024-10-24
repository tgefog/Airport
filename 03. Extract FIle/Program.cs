using System.Runtime.CompilerServices;

namespace _03._Extract_FIle
{
    /*
     C:\Internal\training-internal\Template.pptx
    C:\Projects\Data-Structures\LinkedList.cs 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = string.Empty;
            string fileExtension = string.Empty;

            string filepath = Console.ReadLine();

            int lastSeparatorIndex = filepath.LastIndexOf('\\');
            int extensionIndex = filepath.LastIndexOf('.');
            if (lastSeparatorIndex != -1 && extensionIndex != -1 && extensionIndex > lastSeparatorIndex)
            {
                fileName = filepath.Substring(lastSeparatorIndex + 1, extensionIndex - lastSeparatorIndex - 1);
                fileExtension = filepath.Substring(extensionIndex + 1);
            }


            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}