using CSharpMastery;

Console.WriteLine("===== Lesson 2: Classes ===");
Console.WriteLine();

//Creating objects - multiple ways!

// 1. Using constructor
var person1 = new Person("Kenon", "Sahirani", 32);
person1.Introduce();

//2 . Using object initializer(C# feature - very useful!)
var person2 = new Person
{
    FirstName = "Kenon",
    LastName = "Sahirani",
    Age = 30
};
person2.Introduce();

//3. Using empty constructor then setting properties
var person3 = new Person();
person3.FirstName = "Kenon";
person3.LastName = "Sahirani";
person3.Age = 28;
person3.Introduce();

//Accessing properties (no getFirstName()  needed!)
Console.WriteLine();
Console.WriteLine($"Person 1's full name: {person1.FullName}");
Console.WriteLine($"Person 1's age: {person2.Age}");
//To String
Console.WriteLine();
Console.WriteLine(person1.ToString());
Console.WriteLine(person2);