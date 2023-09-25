
public readonly struct Date
{
    public Day Day { get; init; }
    public Month Month { get; init; }
    public int Year { get; init; }
    public System.DayOfWeek DayOfWeek { get; init; }
   
    public Date (Day Day, Month month, int year, DayOfWeek DayOfWeek)
    {
        // Calc at run time
        this.DayOfWeek = DayOfWeek;
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
    Seventh,
    Eighth,
    Nineth,
    Tenth,
    Eleventh,
    Twelevth,
    Thirteenth,
    Fourteenth,
    Fithteenth,
    Sixteenth,
    Seventeenth,
    Eighteenth,
    Nineteenth,
    Twentieth,
    TwentyFirst,
    TwentySecond,
    TwentyThird,
    TwentyFourth,
    TwentyFifth,
    TwentySixth,
    TwentySeventh,
    TwentyEighth,
    TwentyNineth,
    Thirtieth,
    ThirtyFirst,
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