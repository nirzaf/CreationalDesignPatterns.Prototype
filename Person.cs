public class Person : ICloneable
{
    public readonly string[] Names;
    public readonly Address Address;

    public Person()
    {
        Console.WriteLine("Person Initialized");   
    }

    public Person(string[] names, Address address)
    {
        Names = names;
        Address = address;
    }

    public override string ToString()
    {
        return $"{nameof(Names)}: {string.Join(",", Names)}, {nameof(Address)}: {Address}";
    }

    public object Clone()
    {
        return new Person(Names, Address);
    }

    private new void MyMethod()
    {
        Console.WriteLine("This is private Method");
    }
}