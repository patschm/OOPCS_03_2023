namespace CustomTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int weekDay = 2;

            WeekDay day = WeekDay.Monday;

            Console.WriteLine(day);
            Console.WriteLine((int)day);
            Console.WriteLine((WeekDay)weekDay);
        }
    }

    enum WeekDay
    {
        Sunday = -7,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

}