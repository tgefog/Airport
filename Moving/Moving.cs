using System;
namespace Moving
{
    internal class Moving
    {
        static void Main(string[] args)
        {
            //1.Четем от конзола
            //Широчина на свободното пространство
            int spaceWidth = int.Parse(Console.ReadLine());
            //Дълбочина на свободното пространство
            int spaceDepth = int.Parse(Console.ReadLine());
            //Височина на свободното пространство
            int spaceHeigth = int.Parse(Console.ReadLine());
            int spaceSize = spaceWidth * spaceDepth * spaceHeigth;
            string input;
            //2. While цикъл (input!=Done) въвеждаме брой кашони които се пренасят(инт)
            while ((input = Console.ReadLine()) != "Done")
            {
                if (spaceSize >= int.Parse(input))
                {
                    spaceSize -= int.Parse(input);
                }
                else
                {
                    //ако няма място и нямаме done
                    Console.WriteLine($"No more free space! You need {Math.Abs(int.Parse(input) - spaceSize)} Cubic meters more.");
                    break;
                }
            }
            //при Done и има още място 
            if (input == "Done")
            {
                Console.WriteLine($"{spaceSize} Cubic meters left.");
            }



        }
    }
}