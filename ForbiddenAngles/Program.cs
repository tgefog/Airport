using System.ComponentModel.Design;

namespace ForbiddenAngles
{
    public struct ForbiddenAngle
    {
        public double lower;
        public double higher;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bool validAngles = false;
            double minValidAngle = 180.0;
            ForbiddenAngle[] forbiddenAngles = new ForbiddenAngle[2];
            //360 Degrees test
            forbiddenAngles[0].lower = 0.0;
            forbiddenAngles[0].higher = 0.0;
            forbiddenAngles[1].lower = 0.0;
            forbiddenAngles[1].higher = 0.0;
            Console.WriteLine($"Valid angles for 360 degrees: {CheckValidAngles(forbiddenAngles, minValidAngle)}");

            //270 Degrees test
            forbiddenAngles[0].lower = 135.0;
            forbiddenAngles[0].higher = 181.0;
            forbiddenAngles[1].lower = -181.0;
            forbiddenAngles[1].higher = -135.0;
            Console.WriteLine($"Valid angles for 270 degrees: {CheckValidAngles(forbiddenAngles, minValidAngle)}");

            //270 upside down Degrees test unsure
            forbiddenAngles[0].lower = -45.0;
            forbiddenAngles[0].higher = 0.0;
            forbiddenAngles[1].lower = 0.0;
            forbiddenAngles[1].higher = 45.0;
            Console.WriteLine($"Valid angles for 270 degrees upside down: {CheckValidAngles(forbiddenAngles, minValidAngle)}");

            //220 Degrees test
            forbiddenAngles[0].lower = 130.0;
            forbiddenAngles[0].higher = 181.0;
            forbiddenAngles[1].lower = -181.0;
            forbiddenAngles[1].higher = -90.0;
            Console.WriteLine($"Valid angles for 220 degrees: {CheckValidAngles(forbiddenAngles, minValidAngle)}");

            //60 Degrees test
            forbiddenAngles[0].lower = 30.0;
            forbiddenAngles[0].higher = 181.0;
            forbiddenAngles[1].lower = -181.0;
            forbiddenAngles[1].higher = -30.0;
            Console.WriteLine($"Valid angles for 60 degrees: {CheckValidAngles(forbiddenAngles, minValidAngle)}");

            //100 Degrees sideways test
            forbiddenAngles[0].lower = 140.0;
            forbiddenAngles[0].higher = 181.0;
            forbiddenAngles[1].lower = -181.0;
            forbiddenAngles[1].higher = 40.0;
            Console.WriteLine($"Valid angles for 100 degrees sideways: {CheckValidAngles(forbiddenAngles, minValidAngle)}");

            //Invalid Degrees with gap test
            forbiddenAngles[0].lower = 120;
            forbiddenAngles[0].higher = 130;
            forbiddenAngles[1].lower = -130;
            forbiddenAngles[1].higher = -120;
            Console.WriteLine($"Valid angles for invalid degrees: {CheckValidAngles(forbiddenAngles, minValidAngle)}");
        }
        //higher always > lower and valid angle >= 180, forbidden angles shouldnt have gaps;
        private static bool CheckValidAngles(ForbiddenAngle[] forbiddenAngles, double minValidAngle)
        {
            double allowedAngle = 0.0;
            bool gapBetweenForbiddenAngles = false;

            if (Math.Abs(180 - forbiddenAngles[0].lower + (180 - Math.Abs(forbiddenAngles[1].higher))) > 2 ||
                 (forbiddenAngles[0].lower != 0.0 && forbiddenAngles[1].higher != 0.0))  //60 + 60 > 1  -1 + -1 >  
            {
                gapBetweenForbiddenAngles = true;
            }
            if (forbiddenAngles[0].higher >= forbiddenAngles[0].lower
             && forbiddenAngles[1].higher >= forbiddenAngles[1].lower
             && gapBetweenForbiddenAngles == false)
            {
                allowedAngle = 360 - (Math.Abs(forbiddenAngles[0].higher - forbiddenAngles[0].lower) + Math.Abs(forbiddenAngles[1].lower - forbiddenAngles[1].higher));
                Console.WriteLine($"Allowed angle: {allowedAngle}");
                if (allowedAngle >= minValidAngle)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
