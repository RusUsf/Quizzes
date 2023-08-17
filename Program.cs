

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
    if (numbers[10] == 10) ;
    Console.WriteLine("Your code is running good!");
}
catch (Exception)
{
    Console.WriteLine("You've got an exception!");
}


// Q9: How do you read a line of input from the console?
string input = Console.ReadLine();
Console.WriteLine(input);

// Q10: How can you define an enumeration?

var myDay = Days.Monday;
Console.WriteLine(myDay);



// Q11: How can you concatenate strings?
string myFirstName = "Ruslan";
string myLastName = "Dubas";
string fullName = myFirstName + " " + myLastName;
Console.WriteLine(fullName);

// Q12: What is a correct way to define a constant variable?
const int myConstant = 37;
Console.WriteLine($"The value of myConstant is {myConstant}.");

// Q13: How do you write a switch statement?

var dayOfWeek = Days.Wednesday;

switch (dayOfWeek)
{
    case Days.Monday:
        Console.WriteLine("It's Monday!");
        break;
    case Days.Tuesday:
        Console.WriteLine("It's Tuesday!");
        break;
    case Days.Wednesday:
        Console.WriteLine("It's Wednesday!");
        break;
    case Days.Thursday:
        Console.WriteLine("It's Thursday!");
        break;
    case Days.Friday:
        Console.WriteLine("It's Friday!");
        break;
    default:
        Console.WriteLine("Invalid day!");
        break;
}




// Q15: How do you define and call lambda expression?
Func<int, int, int> add = (x, y) => x + y;
int sum = add(3, 4);
Console.WriteLine(sum);

// Q14: How do you declare and use delegate?
//MyDelegate myDelegate = ShowMessage;
//myDelegate("Hello, Delegate!");

// Q17: How do you convert string to an integer?
int myNumberOne = int.Parse("42");
Console.WriteLine(myNumberOne);


// Q16: How can you instantiate the list of integers?
//List<int> myNumbers = new List<int> { 1, 2, 3, 4, 5, 6 };
//foreach (int number in myNumbers) Console.Write(number + ", ");
//void ShowMessage(string message) { Console.WriteLine(message); }
//public delegate void MyDelegate(string message);

// Q18: How do you define a structure?

Point p = new Point(3, 6);

p.Display();

// Q19: How can you define and start a new thread?
Thread myThread = new Thread(() => { Console.WriteLine("Hello, Thread!"); });
myThread.Start();

// Q20: How to define an interface?

Bird myBird = new Bird();

myBird.Fly();
var birdHeight = myBird.MaximumHeight;

Console.WriteLine(myBird.MaximumHeight + 100);



