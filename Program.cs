// MY first C# program
Console.WriteLine("Hello!");
Console.WriteLine("Welcome to C# learning!");

//Let's try some variables
const string name = "Kenon";
const int yearsExperience = 2;
const string currentStack = "Java Spring Boot";

Console.WriteLine($"My name is {name}!");
Console.WriteLine($"I have {yearsExperience} years of experience!");
Console.WriteLine($"I currently work with {currentStack}!");
Console.WriteLine($"Now I'm learning C#");

// Getting user input
Console.Write("What is your name? ");
var nameInput = Console.ReadLine();

Console.Write("How many years of coding experience do you have? ");
var input = Console.ReadLine();
var years = int.Parse(input!);

Console.WriteLine();
Console.WriteLine($"Nice to meet you, {nameInput}!");
Console.WriteLine($"Wow, {years} years of experience!");

switch (years)
{
    case < 3:
        Console.WriteLine("You're still early in your journey — keep learning!");
        break;
    case < 5:
        Console.WriteLine("You're becoming a solid developer!");
        break;
    default:
        Console.WriteLine("You're experienced! Consider mentoring others.");
        break;
}