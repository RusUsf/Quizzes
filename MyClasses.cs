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

