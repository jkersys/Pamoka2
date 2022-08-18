namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Enum!");


            EDaysOfWeek today = EDaysOfWeek.Tuesday;
            Console.WriteLine($"today: {today}");
            int todayInt = (int)EDaysOfWeek.Tuesday;
            Console.WriteLine($"today: {todayInt}");


            int todayNumber = 2;
            EDaysOfWeek today1 = (EDaysOfWeek)todayNumber;
            Console.WriteLine($"today1: {today1}");

            EDaysOfWeek today2 = (EDaysOfWeek)2; // magic num ber, nenaudoti tokios formos

            int today3 = DayOfWeekEnum.Thursday;

        }
    }

    public enum EDaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
    }

    public enum EDaysOfWeek1
    {
        Sunday = 5,
        Monday = 6,
        Tuesday = 7,
        Wednesday = 8,
        Thursday = 9,
        Friday = 10,
        Saturday = 11,
    }



}