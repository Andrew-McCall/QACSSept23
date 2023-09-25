Console.WriteLine("Hello, hrhrWorld!");

// Comment is not ran. This is just text for the developer
// Console.WriteLine("Hello, hrhrWorld!");

/* 
    multilined
    commenet
 */

// Variables (mutable data stores)
// DataType Idtentifer = Value;

/// Value Types
int myNumber = 0; // +-2.1 billion 32bit (signed)
Console.WriteLine(myNumber);

long myLong = 0; // +-9 septillion 64bit (signed)
ulong myULong = 0; // 18 septillion 64bit
sbyte myByte = -127; // -128 to 127

float myFloat = 09.532f;        // 32 bit
double myDouble = 9532.523d;    // 64 bit
decimal myDecimal = 9532.523m;  // 128 bit

char myChar = '\0';     // 16 bit unicode
bool myBoolean = false; // 1 bit

/// ? makes it nullable
bool? myBool = null;
myBool = true;          // mutable bool gets changed

// .Net API Reference
System.Int32 myNumberCopy = myNumber; 


/// Reference Type
// Structs, Enums, Class e.g String
string myString = "HEllo World";
string myString2 = null;        // All ref types can be null

HairColour hairColour = HairColour.Platinum; // Conditional Logic

Person andrew = new Person(20, "Andrew");
// andrew.age = 21;  Read only struct
Console.WriteLine(andrew.Age);
Console.WriteLine(andrew.Name);
Console.WriteLine(andrew.HairColour);
Console.WriteLine((int) andrew.HairColour);

// Create 3 efficent variables
// -523526326269
// 63.66666636666
// 0

long one = -523526326269;
decimal two = 63.66666636666m;
bool three = false;

// +, -, *, / The varaibles.
// Printing the answer.
// Check the answer to see if its correct.

// Casting is (DataType). Forces dataType change
long oneXtwo = (long) (two * one);
Console.WriteLine(one * two); // double  -33331175948731.61194379154
Console.WriteLine(oneXtwo);   // long      -33331175948731

myNumber = 58235;
long interger = myNumber;
Console.WriteLine(interger);

// Console.WriteLine(one + (int)three); // Some data types cant be mathed. Char

// Date Struct
// - DayEnum
// - MonthEnum
// - Year number


Date ds = new Date(Day.Second, Month.April, 2023);
Console.WriteLine(ds);
Console.WriteLine(ds.Year);
Console.WriteLine(ds.Month);
Console.WriteLine(ds.Day);

// Create the date struct and print it. 
// Access it's properites

// Ext
// BankAccount Struct
//  - Date Struct
//  - balance
//  - account name
//  - account id
BankAccount ba = new BankAccount(5235.25, "Savings?!", 432, new Date(Day.Fourth, Month.April, 2002));
Console.WriteLine(ba.DateCreated.Year);
Console.WriteLine(ba.DateCreated.Month);
Console.WriteLine(ba.AccountName);
Console.WriteLine(ba.Balance);