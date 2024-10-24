using System;
namespace Histogram
{
    internal class Histogram
    {
        static void Main(string[] args)
        {

            //1.Четем N от кнзолата - броя на числата които да очакваме
            int n = int.Parse(Console.ReadLine());
            int p1 = 0; //<200
            int p2 = 0; //200..399
            int p3 = 0; //400..599
            int p4 = 0; //600..799
            int p5 = 0; //800..1000

            int num;
            //2.Въздавмае цикъл, който да се изпълнява от 1вото до последното число
            for (int i = 1; i <= n; i++)
            {
                //четем число
                num = int.Parse(Console.ReadLine());
                if (num < 200)
                    p1++;
                else if (num < 400)
                    p2++;
                else if (num < 600)
                    p3++;
                else if (num < 800)
                    p4++;
                else
                    p5++;
            }
            //3. Oтпечатваме какъв % от числата са попаднали във всеки един от диапазоните
            Console.WriteLine($"{(double)p1 / n * 100:f2}%");
            Console.WriteLine($"{(double)p2 / n * 100:f2}%");
            Console.WriteLine($"{(double)p3 / n * 100:f2}%");
            Console.WriteLine($"{(double)p4 / n * 100:f2}%");
            Console.WriteLine($"{(double)p5 / n * 100:f2}%");
        }
    }
}