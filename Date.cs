
public readonly struct Date
{
    public Day Day { get; init; }
    public Month Month { get; init; }
    public int Year { get; init; }

    public Date (Day Day, Month month, int year)
    {
        this.Day = Day;
        this.Month = month;
        this.Year = year;
    }

}

public enum Day
{
    First,
    Second,
    Third,
    Fourth,
    Fifth,
    Sixth,
    // ...
}

public enum Month
{
    January,
    Feburary,
    March,
    April,
    May,
    June,
    July,
    August,
    September,
    November,
    October,
    December
}