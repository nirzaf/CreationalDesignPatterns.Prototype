using static System.Console;

var john = new Person(new []{"John", "Smith"}, new Address("London Road", 123));

var jane = (Person)john.Clone();
jane.Address.HouseNumber = 321; // oops, John is now at 321

// this doesn't work
//var jane = john;

// but clone is typically shallow copy
jane.Names[0] = "Jane";

WriteLine(john);
WriteLine(jane);

var f1 = new Fazrin();

// Hidden method cannot be used in derived class
// f1.MyMethod()

public class Fazrin : Person 
{
    public Fazrin()
    {
        Console.WriteLine("My Name is Fazrin");
    }
}


