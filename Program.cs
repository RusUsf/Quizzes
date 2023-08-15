
// Q1: How to write a "Hello, World" program?
Console.WriteLine("Hello, World!");

// Q2: How to declare and initialize an integer variable?
int myNumber = 15;
Console.WriteLine($"int myNumber = {myNumber}; // Prints {myNumber}");

// Q3: How to perform basic conditional check using an if statement?
if (myNumber > 10) Console.WriteLine("Number is greater than 10.");

// Q4: What is the correct way to define a method that adds two numbers?
int AddNumbers(int a, int b) { return a + b; }
Console.WriteLine(AddNumbers(myNumber, myNumber)); // Prints 30

// Q5: How can you loop through an array of intergers using a froeach loop?
int[] numbers = { 1, 2, 3, 4, 5 };
foreach (int i in numbers) Console.Write(i + ",");

//Q6: see MyClasses.cs

// Q7: How do you create an object of the class Person?
Person person = new Person(37, "Rus");
Console.WriteLine($"\nMy name is {person.Name} and I am {person.Age} years old!");

person.GetInfo();
person.GetInfo("Ruslan");
person.GetInfo("Rus", 37);

// Q8: How do you handle exceptions using try-catch?
try
{
    if (numbers.Contains(1) != true) ;
    Console.WriteLine("Your code is running good!");
}
catch (Exception)
{
    Console.WriteLine("You've got an exception!");
}


