public class Date
{
    protected int Year { get; set; }
    protected int Month { get; set; }
    protected int Day { get; set; }
    protected int Hours { get; set; }
    protected int Minutes { get; set; }

    public Date(int year, int month, int day, int hours, int minutes)
    {
        Year = year;
        Month = month;
        Day = day;
        Hours = hours;
        Minutes = minutes;
    }

    public override string ToString()
    {
        return $"{Year}-{Month}-{Day} {Hours}:{Minutes}";
    }

    public static TimeSpan operator -(Date date1, Date date2)
    {
        DateTime dateTime1 = new DateTime(date1.Year, date1.Month, date1.Day, date1.Hours, date1.Minutes, 0);
        DateTime dateTime2 = new DateTime(date2.Year, date2.Month, date2.Day, date2.Hours, date2.Minutes, 0);

        return dateTime1 - dateTime2;
    }

    public static bool IsEqualDays(Date instance1, Date instance2)
    {
        return instance1.Year == instance2.Year &&
               instance1.Month == instance2.Month &&
               instance1.Day == instance2.Day;
    }
}