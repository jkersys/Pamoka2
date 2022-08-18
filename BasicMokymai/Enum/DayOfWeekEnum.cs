namespace Enum
{
    //alternatyva Enumui, kad turetumem daugiau funkciju ir galimybiu konfiguruoti , todel naudojam statines klases
    public static class DayOfWeekEnum
    {
        public const int Sunday = 1; // const reiskia kad nebus galima pakeisti reiksmes
        public static int Monday { get; set; } = 2;
        public static int Tuesday = 3;
        public static int Wednesday = 4;
        public static int Thursday = 5;
        public static int Friday = 6;
        public static int Saturday = 7;
    }



}