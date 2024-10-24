using System;

namespace Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Въвеждаме месец и брой на нощувки
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studioPrice = 1;
            double apartmentPrice = 1;
            double studioDiscount = 0;
            double apartmentDiscount = 0;
            //Цени Май и октомври	              Юни и септември	                  Юли и август
            //     Студио – 50 лв./ нощувка       Студио – 75.20 лв./ нощувка         Студио – 76 лв./ нощувка
            //     Апартамент – 65 лв./ нощувка   Апартамент – 68.70 лв./ нощувка     Апартамент – 77 лв./ нощувка
            if (month == "May" || month == "October")
            {
                studioPrice = nights * 50;
                apartmentPrice = nights * 65;
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = nights * 75.2;
                apartmentPrice = nights * 68.7;
            }
            else if (month == "July" || month == "August")
            {
                studioPrice = nights * 76;
                apartmentPrice = nights * 77;
            }
            //Отстъпки 
            //Студио при повече от 7 нощувки през май и октомври -> 5%
            if (nights > 7 && nights <= 14 && (month == "May" || month == "October"))
            {
                studioDiscount = 0.05;
            }
            //Студио при повече от 14 нощувки през май и октомври -> 30%
            else if (nights > 14 && (month == "May" || month == "October"))
            {
                studioDiscount = 0.3;
            }
            //Студио при повече от 14 нощувки през щни и септември -> 20%
            else if (nights > 14 && (month == "June" || month == "September"))
            {
                studioDiscount = 0.2;
            }
            //Апартамент при повече от 14 нощувки ->10%
            if (nights > 14)
            {
                apartmentDiscount = 0.1;
            }
            //Изход:
            //"Apartment: {цена за целият престой} lv."
            Console.WriteLine($"Apartment: {apartmentPrice - apartmentPrice * apartmentDiscount:f2} lv.");
            //"Studio: {цена за целият престой}  lv."
            Console.WriteLine($"Studio: {studioPrice - studioPrice * studioDiscount:f2} lv.");
        }
    }
}