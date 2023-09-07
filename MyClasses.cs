// Q6: How can you define a class with property named Age?
public class Person
{
    public int Age { get; set; }
    public string Name { get; set; }
    public Person(int age = 0, string name = "")
    {
        Age = age;
        Name = name;
    }

    public void GetInfo()
    {
        Console.WriteLine("I am a person.");
    }

    public void GetInfo(string name)
    {
        Console.WriteLine($"My name is {name}");
    }

    public void GetInfo(string name, int age)
    {
        Console.WriteLine($"My name is {name} and I am {age} years old!");
    }
}


public class Bird : IFlyable
{
    public void Fly()
    {
        Console.WriteLine("The bird is flying.");
    }

    public int MaximumHeight => 1000;
}

public class MyClass
{
    public int MyProperty { get; private set; }
}

public static class StringExtensions
{
    public static string ToLowerCase(this string input)
    {
        return input.ToLower();
    }
}


// Constructor chaining
public class Animal
{
    public string? Name { get; set; }
    public int? Age { get; set; }
    
    public Animal() : this("Unknown",0) { }
    public Animal(string? name) : this(name, 0) { }
    public Animal(string? name, int? age)
    {
        Name = name;
        Age = age;
    }
}