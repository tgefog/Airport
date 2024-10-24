namespace _11._Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArguments = command.Split();

                switch (commandArguments[0])
                {
                    case "exchange":
                        int index = int.Parse(commandArguments[1]);
                        numbers = ExchangeElements(numbers, index);
                        break;
                    case "max":
                        string maxType = commandArguments[1];
                        PrintMaxNumberIndex(numbers, maxType);
                        break;
                    case "min":
                        string minType = commandArguments[1];
                        PrintMinNumberIndex(numbers, minType);
                        break;
                    case "first":
                        int firstCount = int.Parse(commandArguments[1]);
                        string firstType = commandArguments[2];
                        PrintFirstElements(numbers, firstCount, firstType);
                        break;
                    case "last":
                        int lastCount = int.Parse(commandArguments[1]);
                        string lastType = commandArguments[2];
                        PrintLastElements(numbers, lastCount, lastType);
                        break;
                }
            }
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        static int[] ExchangeElements(int[] array, int index)
        {
            if (CheckForOutOfRange(array, index))
            {
                Console.WriteLine("Invalid index");
                return array;
            }
            int[] changedArray = new int[array.Length];
            int changedArrayIndex = 0;

            for (int i = index + 1; i <= array.Length - 1; i++)
            {
                changedArray[changedArrayIndex++] = array[i];
            }
            for (int i = 0; i <= index; i++)
            {
                changedArray[changedArrayIndex++] = array[i];
            }
            return changedArray;
        }
        private static void PrintMaxNumberIndex(int[] numbers, string type)
        {
            int maxIndex = -1;
            int maxNumber = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                int number = numbers[i];
                if (IsOddorEven(type, number))
                {
                    if (number >= maxNumber)
                    {
                        maxNumber = number;
                        maxIndex = i;
                    }
                }
            }
            PrintNotDefaultIndex(maxIndex);

        }
        private static void PrintMinNumberIndex(int[] numbers, string type)
        {
            int minIndex = -1;
            int minNumber = int.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                int number = numbers[i];
                if (IsOddorEven(type, number))
                {
                    if (number <= minNumber)
                    {
                        minNumber = number;
                        minIndex = i;
                    }
                }
            }
            PrintNotDefaultIndex(minIndex);
        }
        static void PrintFirstElements(int[] numbers, int count, string type)
        {
            if (count > numbers.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            string firstElements = "";
            int elementsCount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int number = numbers[i];
                if (IsOddorEven(type, number))
                {
                    firstElements += $"{number}, ";
                    elementsCount++;
                    if (elementsCount >= count)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"[{firstElements.Trim(' ', ',')}]");
        }
        static void PrintLastElements(int[] numbers, int count, string type)
        {
            if (count > numbers.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            string lastElements = "";
            int elementsCount = 0;
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                int number = numbers[i];
                if (IsOddorEven(type, number))
                {
                    lastElements += $"{number}, " + lastElements;
                    elementsCount++;
                    if (elementsCount >= count)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"[{lastElements.Trim(' ', ',')}]");
        }
        private static void PrintNotDefaultIndex(int maxIndex)
        {
            if (maxIndex != -1)
            {
                Console.WriteLine(maxIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
        static bool IsOddorEven(string type, int number)
        {
            return (type == "even" && number % 2 == 0) ||
                   (type == "odd" && number % 2 != 0);
        }
        static bool CheckForOutOfRange(int[] array, int index)
        {
            return index < 0 || index >= array.Length;
        }
    }
}