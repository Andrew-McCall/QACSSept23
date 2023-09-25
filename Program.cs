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

Date myDate = new Date(Day.Second, Month.June, 2023, DayOfWeek.Friday);

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

switch (myDate.DayOfWeek)
{

    case DayOfWeek.Monday:
        Console.WriteLine("Booo!");
        break;

    case DayOfWeek.Sunday:
    case DayOfWeek.Saturday:
        Console.WriteLine("Weekend Woop!");
        break;

    case DayOfWeek.Tuesday:
        Console.WriteLine("Tommorrow!");
        break;

    default:
        Console.WriteLine("Unknown Day?!");
        break;

}

switch ((int) myDate.DayOfWeek)
{

    case 1:
        Console.WriteLine("Booo!");
        break;

    case 0:
    case 6:
        Console.WriteLine("Weekend Woop!");
        break;

    case 2:
        Console.WriteLine("Tommorrow!");
        break;

    case >= 3: // (int) myDate.DayOfWeek >= 3
        Console.WriteLine("Weekday");
        break;

}

string output = myDate.Day switch
{
    Day.First => "1st",
    Day.Second => "2nd of " + myDate.Month.ToString(),
    Day.Third => "3rd", // Skip case: word. use =>
    _ => "Error", // _ instead of default
};

Console.WriteLine(output);
/*
Console.WriteLine(myDate.Day switch
{
    Day.First => "1st",
    Day.Second => "2nd",
    Day.Third => "3rd",
    _ => "Error",
});
*/

// Create an enum of counrties
// Create a switch case that prints the capital of country variable
// Create a switch expression that turns the capital into its population. Hint: "float population = myCountry switch {..."
// Create a number variable
// Use switches to turn that number into english
// 1 => "One"
// EXT
// 1952 => "one thousand, nine-hundred fifty-two"
