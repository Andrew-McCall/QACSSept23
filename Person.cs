
/// Structs are best for bundling data.
// Structs are for the most simple object.
// Structs usually without behaviour - immuatble
// Structs are more peformant
public readonly struct Person
{
    // Properties. The data held in the struct.
    // Can be read by any class.
    // Can only be set durring creation
    // (Used the auto implent)
    public int Age { get; init; }
    public string Name { get; init; }
    public HairColour HairColour { get; init; }

    // Constructor
    // Method which creates itself
    public Person(int age, string name)
    {
        this.Age = age;
        this.Name = name;
        // Random-code here
        this.HairColour = HairColour.Ginger;
    }

}