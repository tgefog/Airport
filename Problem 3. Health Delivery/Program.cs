namespace Problem_3._Health_Delivery
{
    internal class Program
    {
        /*
         * 
10@10@10@2
Jump 1
Jump 2
Love!

2@4@2
Jump 2
Jump 2
Jump 8
Jump 3
Jump 1
Love!
         */
        static void Main(string[] args)
        {
            int[] houses = Console.ReadLine().Split("@").Select(int.Parse).ToArray();
            string jump;
            int jumpAmount = 0;
            int cupidIndex = 0;
            while ((jump = Console.ReadLine()) != "Love!")
            {
                jumpAmount = int.Parse(jump.Split(" ")[1]);
                cupidIndex += jumpAmount;//out of range exception
                if (cupidIndex >= houses.Length)
                {
                    cupidIndex = 0;
                }

                houses[cupidIndex] -= 2;
                if (houses[cupidIndex] == 0)
                {
                    Console.WriteLine($"Place {cupidIndex} has Valentine's day.");
                }
                if (houses[cupidIndex] < 0)
                {
                    Console.WriteLine($"Place {cupidIndex} already had Valentine's day.");
                }
            }
            Console.WriteLine($"Cupid's last position was {cupidIndex}.");
            int failedHouses = 0;
            for (int i = 0; i < houses.Length; i++)
            {
                if (houses[i] > 0)
                {
                    failedHouses++;
                }
            }
            if (failedHouses > 0)
            {
                Console.WriteLine($"Cupid has failed {failedHouses} places.");
            }
            else
            {
                Console.WriteLine("Mission was successful.");
            }
        }
    }
}