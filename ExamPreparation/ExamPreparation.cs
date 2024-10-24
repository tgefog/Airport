using System;

namespace ExamPreparation
{
    internal class ExamPreparation
    {
        static void Main(string[] args)
        {
            //1. Четем от конзолата брой на незадоволителните оценки, които може да получи
            int allowedBadGrades = int.Parse(Console.ReadLine());
            //2.Променливи за :
            //броя на незадоволителните оценки
            int currentBadGrades = 0;
            //броя на всикчи оценки
            int count = 0;
            //име на последна задача
            string lastTask = string.Empty;
            //сумата на всички оценки
            double totalgrades = 0;
            string task;
            //3. Създаваме while цикъл, който да се изпълнява, докато не получим съобщението "Enough"
            while ((task = Console.ReadLine()) != "Enough")
            {
                //ако задачата е различна от "Enough", то тя е последната задача
                lastTask = task;
                //четем оценката на текущата задача
                double grade = double.Parse(Console.ReadLine());
                //добавяме оценката към сумата на всички оценки
                totalgrades += grade;
                //проверяваме дали оценката е задоволителна
                if (grade <= 4.00)
                {
                    //ако не е задоволителна, увеличаваме броча на незадоволителни уценки с 1
                    currentBadGrades++;
                }
                //увеличаваме брояча на всички оценки с 1
                count++;
                //проверяваме дали е достигнал броя на незадоволителните оценки
                if (currentBadGrades >= allowedBadGrades)
                {
                    //ако да, спираме цикъла
                    Console.WriteLine($"You need a break, {currentBadGrades} poor grades.");
                    break;
                }
            }
            if (task == "Enough")
            {
                Console.WriteLine($"Average score: {(double)totalgrades / count:f2}");
                Console.WriteLine($"Number of problems: {count}");
                Console.WriteLine($"Last problem: {lastTask}");
            }
        }
    }
}