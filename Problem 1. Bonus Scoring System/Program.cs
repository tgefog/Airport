namespace Problem_1._Bonus_Scoring_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int lectures = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());

            decimal maxBonus = 0;
            int maxAttendancies = 0;

            for (int i = 0; i < students; i++)
            {
                int attendance = int.Parse(Console.ReadLine());
                decimal totalBonus = Math.Ceiling((decimal)attendance / lectures * (5 + additionalBonus));
                if (totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                    maxAttendancies = attendance;
                }
            }
            Console.WriteLine($"Max Bonus: {maxBonus}.");
            Console.WriteLine($"The student has attended {maxAttendancies} lectures.");
        }
    }
}