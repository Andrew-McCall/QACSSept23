// >  Greater
// <  Lesser
// == Equal
// != Not Equal
// >= Greater OR Equal
// <= Lesser OR Equal

// && AND 
// || OR

// !  Make a true = false, false = true

int x = 0;
while (x < 1000)
{
    Console.WriteLine(x);
    x = x + 3;

    x++;       // + 1

    x += 3;
};

string greeting = "";
while (greeting.Length < 30)
{
    Console.WriteLine(greeting);
    greeting += "H ";
};

while (true)
{
    Console.WriteLine("While True");

    x += 5;
    if (x > 200)
    {
        break; // can exit any loop.
    }
   
};

for (int i = 10; i > 0; i--)
{
    Console.WriteLine(i);
};

for (int counter = 1; counter % 7 != 0; counter += 2)
{
    Console.WriteLine(counter);
};

for (int i = 0; i < 50; i++)
{
    Console.WriteLine(i);
    i += 10;
}

// print out 0 to 10
// print out 100 to 0 counting backwards in 9

// play 99 green bottles on the wall
// there are 99 green bottle on the wall and if one were to fall, there would be 98 bottles on the wall.
// no negative print outs

for (int i = 99; i > 0; i--)
{
    // $"hello {nameVar}" = "hello "+nameVar
    if (i == 1)
    {
        Console.WriteLine($"There is 1 green bottle on the wall, And if that one were to fall, Then there would be no more bottles on the wall.");
    }
    else
    {
        Console.WriteLine($"There are {i} green bottles on the wall, And if one were to fall, Then there would be {i - 1} greens bottles on the wall.");
    }
}

/*
for (int i = 99; i >= 2; i--)
{
    // $"hello {nameVar}" = "hello "+nameVar
    Console.WriteLine($"There are {i} green bottles on the wall, And if one were to fall, Then there would be {i - 1} greens bottles on the wall.");
};
Console.WriteLine($"There is 1 green bottle on the wall, And if that one were to fall, Then there would be no more bottles on the wall.");
*/