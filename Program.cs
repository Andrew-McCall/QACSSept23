// >  Greater
// <  Lesser
// == Equal
// != Not Equal
// >= Greater OR Equal
// <= Lesser OR Equal

// && AND 
// || OR

// !  Make a true = false, false = true

bool logic = true;

if (logic)
{
    Console.WriteLine("Hello World!");
}

if (1 > 0)
{
    Console.WriteLine("One is greater than 0");
}

if (0 == 0)
{
    Console.WriteLine("Cat");
}

if (1 != 0)
{
    Console.WriteLine("Dog");
}

logic = true;

if (!logic) // false
{
    Console.WriteLine("Hampster");
}
else
{
    Console.WriteLine("Guinea Pig!");
}

if (logic)
{
    Console.WriteLine("andrew");
} else
{
    Console.WriteLine("McCall");
}

int age = 65;
bool hasRetired = false;

if (age < 18) // 18 < 18 == FALSE
{
    Console.WriteLine("Child");
}
else if (age <= 65 && !hasRetired) // AND is only true if both sides are true
{
    Console.WriteLine("Adult");
}
else
{
    Console.WriteLine("Retired");
}

if (hasRetired || !hasRetired)  // OR is true if at least one side is true
{
    Console.WriteLine("Question?!");
}

// XOR age > 65 |X| hasRetired true
if (age > 65 && !hasRetired || age <= 65 && hasRetired)
{

}

if ( !(age > 10)) // (age > 10) == false
{
    Console.WriteLine("Here?");
}

// Create a Date (Variable)
/// Print which holiday day that date is
// e.g if Date.Day == Day.Sunday -> "Weekend!"
// Christmas
// You Birthday
// Summer Holiday Start
// Your birthday DAY with the correct year

Date myDate = new Date(Day.TwentyFifth, Month.June, 2023, DayOfWeek.Sunday);

if (  (myDate.Day == Day.Thirtieth && myDate.Month == Month.September) || (myDate.Day == Day.First && myDate.Month == Month.October))
{
    Console.WriteLine("This Weekend!");
} else if ( myDate.Day == Day.TwentyFifth && myDate.Month == Month.December)
{
    Console.WriteLine("birth of sir issac newton");
}
else if(myDate.DayOfWeek == DayOfWeek.Sunday || myDate.DayOfWeek == DayOfWeek.Saturday)
{
    Console.WriteLine("WEEK END!!");
}else
{
    Console.WriteLine("Nothing SEpcial");
}