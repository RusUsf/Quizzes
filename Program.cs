﻿

//// Q1: How to write a "Hello, World" program?
//Console.WriteLine("Hello, World!");

//// Q2: How to declare and initialize an integer variable?
//int myNumber = 15;
//Console.WriteLine($"int myNumber = {myNumber}; // Prints {myNumber}");

//// Q3: How to perform basic conditional check using an if statement?
//if (myNumber > 10) Console.WriteLine("Number is greater than 10.");

//// Q4: What is the correct way to define a method that adds two numbers?
//int AddNumbers(int a, int b) { return a + b; }
//Console.WriteLine(AddNumbers(myNumber, myNumber)); // Prints 30

//// Q5: How can you loop through an array of intergers using a froeach loop?
//int[] numbers = { 1, 2, 3, 4, 5 };
//foreach (int i in numbers) Console.Write(i + ",");

////Q6: see MyClasses.cs

//// Q7: How do you create an object of the class Person?
//Person person = new Person(37, "Rus");
//Console.WriteLine($"\nMy name is {person.Name} and I am {person.Age} years old!");

//person.GetInfo();
//person.GetInfo("Ruslan");
//person.GetInfo("Rus", 37);

//// Q8: How do you handle exceptions using try-catch?
//try
//{
//    if (numbers[10] == 10) ;
//    Console.WriteLine("Your code is running good!");
//}
//catch (Exception)
//{
//    Console.WriteLine("You've got an exception!");
//}


//// Q9: How do you read a line of input from the console?
//string input = Console.ReadLine();
//Console.WriteLine(input);

//// Q10: How can you define an enumeration?

//var myDay = Days.Monday;
//Console.WriteLine(myDay);



//// Q11: How can you concatenate strings?
//string myFirstName = "Ruslan";
//string myLastName = "Dubas";
//string fullName = myFirstName + " " + myLastName;
//Console.WriteLine(fullName);

//// Q12: What is a correct way to define a constant variable?
//const int myConstant = 37;
//Console.WriteLine($"The value of myConstant is {myConstant}.");

//// Q13: How do you write a switch statement?

//var dayOfWeek = Days.Wednesday;

//switch (dayOfWeek)
//{
//    case Days.Monday:
//        Console.WriteLine("It's Monday!");
//        break;
//    case Days.Tuesday:
//        Console.WriteLine("It's Tuesday!");
//        break;
//    case Days.Wednesday:
//        Console.WriteLine("It's Wednesday!");
//        break;
//    case Days.Thursday:
//        Console.WriteLine("It's Thursday!");
//        break;
//    case Days.Friday:
//        Console.WriteLine("It's Friday!");
//        break;
//    default:
//        Console.WriteLine("Invalid day!");
//        break;
//}




//// Q15: How do you define and call lambda expression?
//Func<int, int, int> add = (x, y) => x + y;
//int sum = add(3, 4);
//Console.WriteLine(sum);

//// Q14: How do you declare and use delegate?
////MyDelegate myDelegate = ShowMessage;
////myDelegate("Hello, Delegate!");

//// Q17: How do you convert string to an integer?
//int myNumberOne = int.Parse("42");
//Console.WriteLine(myNumberOne);


//// Q16: How can you instantiate the list of integers?
////List<int> myNumbers = new List<int> { 1, 2, 3, 4, 5, 6 };
////foreach (int number in myNumbers) Console.Write(number + ", ");
////void ShowMessage(string message) { Console.WriteLine(message); }
////public delegate void MyDelegate(string message);

//// Q18: How do you define a structure?

//Point p = new Point(3, 6);

//p.Display();

//// Q19: How can you define and start a new thread?
//Thread myThread = new Thread(() => { Console.WriteLine("Hello, Thread!"); });
//myThread.Start();

//// Q20: How to define an interface?

//Bird myBird = new Bird();

//myBird.Fly();
//var birdHeight = myBird.MaximumHeight;

//Console.WriteLine(myBird.MaximumHeight + 100);



//// Q21: How to use LINQ to query a collection of integers?
//var myNumbersList = new List<int> { 1, 2, 3, 4, 5 };
//var evenNumber = myNumbersList.Where(n => n % 2 == 0);
//foreach (var item in evenNumber)
//{
//    Console.Write(item+",");
//}

//// Q22: How to asynchronously read a text file?
//using (StreamReader reader = new StreamReader("Twenty_CSharp_Questions.txt"))
//{
//    string content = await reader.ReadToEndAsync();
//    Console.WriteLine(content);
//}

//// Q23: How to create a property with a private setter?


//// Q24: How to handle different exceptions using multiple catch blocks?
//int[] myArray = { 1, 2, 3, 4, 5 };

//try
//{
//    Console.WriteLine(myArray[10]);
//}
//catch(FileNotFoundException e)
//{
//    Console.WriteLine("File not found!");
//}
//catch(IndexOutOfRangeException e)
//{
//    Console.WriteLine("There are only five days in the WorkDays!");
//}
//finally
//{
//    Console.WriteLine("You are doing great learning C Sharp! Keep it up!");
//}

//// Q25: How to use string interpolation?
//string city = "Sarasota";
//string greeting = $"Welcome to {city}!";
//Console.WriteLine(greeting);

//// Q26: How to use the 'using' statement for automatic resource management?
//using (StreamWriter writer = new StreamWriter("TestTextFile.txt"))
//{
//    writer.WriteLine($"Hello, {myFirstName}, you're doing great learning C Sharp! Keep it up!");
//}

//using (StreamReader reader = new StreamReader("TestTextFile.txt"))
//{
//    string content = await reader.ReadToEndAsync();
//    Console.WriteLine(content);
//}

//// Q27: How to use extension methods?

//var myVariable = "Do not expect immediate results!";
//var myVarLowerCase = myVariable.ToLowerCase();
//Console.WriteLine(myVarLowerCase);




// Quiz 5

//int sixteen = 0b0001_0000;
//Console.WriteLine(sixteen);

//Action<int> DoSomething = i => Console.WriteLine(i);

//DoSomething(50);


//Shape sq = new Square();
//sq.Sides = 4;
//class Shape
//{
//    public int Sides { get; set; }
//}

//class Square : Shape
//{
//    public int GetSides()
//    {
//        return this.Sides;
//    }
//}

using System.Security.Cryptography;


//MyPerson p = new MyPerson();
//p.Intro("Rus",37);
//class MyPerson
//{

//    public void Intro(int age, string name)
//    {
//        Console.WriteLine("My name is " + name);
//    }

//    public void Intro(string name, int age = 0)
//    {
//        Console.WriteLine($"My name is {name} and I am {age} years old");
//    }
//}



//MyPrinter myprnt=new MyPrinter();
//myprnt.Install();
//class MyPrinter
//{
//    public virtual void Install()
//    {
//        Console.WriteLine("Printer Installed");
//    }

//    public virtual void Print(string text)
//    {
//        Console.WriteLine("Printing: " + text);
//    }
//}

//class MyLaserPrinter : MyPrinter
//{
//    public void Install()
//    {
//        Console.WriteLine("Laser Printer Installed Successfully.");
//    }
//}


//var input = "100";
//if (int.TryParse(input, out int result)) Console.WriteLine(result);
//else Console.WriteLine("Could not parse input!");

//global::System.Console.WriteLine("Great work for studying C#! Well done! Keep it up!");

// Quiz 7

//Predicate<int> GetBool = delegate (int val)
//{
//    if (val <= 0) return false;
//    else return true;
//};
//Console.WriteLine(GetBool(-1));



//Processor<int> p = new Processor<int>();
//p.BaseValue = 1;
//int result = p.Add(10);
//Console.WriteLine(result);

//class Processor<T>
//{
//    public int Add(int value)
//    {
//        return this.BaseValue + value;
//    }

//    public int BaseValue { get; set; }
//}




//Processor<int> p1 = new DataProcessor<int>();
//p1.Process(100);

//DataProcessor<string> p2 = new DataProcessor<string>();
//p2.Process("TEST");

//class Processor<T>
//{
//    public void Process(T value)
//    {
//        Console.WriteLine(value.GetType().Name+"");
//    }
//}

//class DataProcessor<U> : Processor<U> { }




Console.WriteLine("Coding Pro-Tip: Read, Do, Read, Do, Read, Do! ");



Animal animal = new Animal();
Animal animal2 = new Animal("Monkey");
Animal animal3 = new Animal("MonkeyThree", 7);

Console.WriteLine($" Animal one: name {animal.Name}, age: {animal.Age}");
Console.WriteLine($"Animal two: name {animal2.Name}, age: {animal2.Age}");
Console.WriteLine($"Animal three: name {animal3.Name}, age: {animal3.Age}");








