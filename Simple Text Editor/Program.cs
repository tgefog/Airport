namespace Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string text = string.Empty;//Replace with Stringbuilder
            Stack<string> states = new Stack<string>();
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "1")
                {
                    states.Push(text);
                    text += command[1];

                }
                else if (command[0] == "2")
                {
                    states.Push(text);
                    int count = int.Parse(command[1]);
                    text = text.Substring(0, text.Length - count);
                }
                else if (command[0] == "3")
                {
                    int index = int.Parse(command[1]);
                    Console.WriteLine(text[index - 1]);
                }
                else if (command[0] == "4")
                {
                    text = states.Pop();
                }
            }
        }
    }
}