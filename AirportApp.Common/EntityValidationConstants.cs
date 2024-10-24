namespace AirportApp.Common
{
    public static class EntityValidationConstants
    {
        public static class Aircraft
        {
            public const int ModelMaxLength = 50;
            public const int ModelMinLeght = 2;
            public const int ManufacturerMaxLength = 60;
            public const int ManufacturerMinLength = 3;
            public const int RegistrationNumberMaxLength = 6;
            public const int RegistrationNumberMinLength = 1;
        }
        public static class Airline
        {
            public const int NameMaxLength = 50;
            public const int CodeMaxLength = 3;
            public const int CountryMaxLength = 60;
            public const int CountryMinLength = 2; 
        }
        public static class Baggage
        {
            public const int TagNumberMaxLength = 10;
            public const int WeightMinPrecision = 2;
            public const int WeightMaxPrecision = 18;
        }
        public static class Booking
        {
            public const int SeatNumberMaxLength = 3;
        }
        public static class Flight
        {
            public const int NumberMaxLength = 4;
            public const int OriginMaxLength = 60;
            public const int OriginMinLength = 2;
            public const int DestinationMaxLength = 60;
            public const int DestinationMinLength = 2;
        }
        public static class Gate
        {
            public const int GateNumberMaxLength = 3;
        }
        public static class Passenger 
        { 
            public const int FirstNameMaxLength = 100;
            public const int FirstNameMinLength = 1;
            public const int LastNameMaxLength = 100;
            public const int LastNameMinLength = 1;
            public const int PassportNumberMaxLength = 9;
        }
        public static class StaffMember
        {
            public const int FirstNameMaxLength = 100;
            public const int FirstNameMinLength = 1;
            public const int LastNameMaxLength = 100;
            public const int LastNameMinLength = 1;
            public const int PositionMaxLength = 50;
            public const int SalaryMinPrecision = 2;
            public const int SalaryMaxPrecision = 18;
        }
        public static class Terminal
        {
            public const int NameMaxLength = 80;
        }
    }
}
