using System;
using System.ComponentModel.DataAnnotations;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inputs
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            bool trashHeadset = false;
            bool trashMouse = false;
            double totalExpenses = 0;
            int headsetsTrashed = 0; //Trash one headset for every second lost game
            int mousesetsTrashed = 0; //Trash one mouse for every third lost game
            int keyboardsetsTrashed = 0; //Trash one keyboard if both mouse and headset trashed in same game
            int displaysTrashed = 0; //Trash one display for every two keyboards

            //Body
            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    headsetsTrashed += 1;
                    trashHeadset = true;
                }
                if (i % 3 == 0)
                {
                    mousesetsTrashed += 1;
                    trashMouse = true;
                }
                if (trashMouse == true && trashHeadset == true)
                {
                    keyboardsetsTrashed += 1;
                }
                trashHeadset = false;
                trashMouse = false;
            }
            displaysTrashed = keyboardsetsTrashed / 2;

            totalExpenses = keyboardsetsTrashed * keyboardPrice + mousesetsTrashed * mousePrice + headsetsTrashed * headsetPrice + displaysTrashed * displayPrice;

            //Output
            Console.WriteLine($"Rage expenses: {totalExpenses:f2} lv.");
        }
    }
}