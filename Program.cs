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