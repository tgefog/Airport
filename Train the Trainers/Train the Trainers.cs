using System;
namespace Train_the_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inputs/Variables
            int juryCount = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string presentationName;
            double grade = 0.0;
            double personalGrade = 0.0;
            int presentationCount = 0;

            //2. while, който се изпълнява до получаване на "Finish"
            while (input != "Finish")
            {
                //име на презентация = input
                presentationName = input;
                grade = 0;
                //изпълнява се for i=1;i<=juryCount
                for (int i = 1; i <= juryCount; i++)
                {
                    //четем оценка на моментната презентация и я добавяме към сумата на останалите
                    grade += double.Parse(Console.ReadLine());
                }
                grade /= juryCount;
                //otpechatvame "{името на презентацията} - {средна оценка}."
                Console.WriteLine($"{presentationName} - {grade:f2}.");
                personalGrade += grade;
                presentationCount++;
                //nov vhod
                input = Console.ReadLine();
            }
            //3. Отпечатваме средната оценка от всички презентации
            Console.WriteLine($"Student's final assessment is {(personalGrade / presentationCount):f2}.");
        }
    }
}