/*
23 -2 321 87 42 90 -123
swap 1 3
swap 3 6
swap 1 0
multiply 1 2
multiply 2 1
decrease
end

1 2 3 4
swap 0 1
swap 1 2
swap 2 3
multiply 1 2
decrease
end
*/
namespace Problem_2._Array_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> elements = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split();
                int index1 = 0;
                int index2 = 0;
                switch (arguments[0])
                {
                    case "swap":
                        index1 = int.Parse(arguments[1]);
                        index2 = int.Parse(arguments[2]);

                        int swapTemp = elements[index1];

                        elements[index1] = elements[index2];
                        elements[index2] = swapTemp;
                        break;
                    case "multiply":
                        index1 = int.Parse(arguments[1]);
                        index2 = int.Parse(arguments[2]);

                        elements[index1] = elements[index1] * elements[index2];
                        break;
                    case "decrease":
                        for (int i = 0; i < elements.Count; i++)
                        {
                            elements[i]--;
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", elements));
        }

    }
}