namespace CSharpMastery;

public class Person(string firstName, string lastName, int age)
{
    //Properties (C# way - no more getters/setters!)
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;
    public int Age { get; set; } = age;

    //Read-only property (computed)
    public string FullName => $"{FirstName} {LastName}";
    
    //Empty Constructor
    public Person() : this("", "", 0)
    {
    }
    
    //Method
    public void Introduce()
    {
        Console.Write($"Hi, I'm {FullName} and I'm {Age} years old. ");
    }
    
    //Override ToString (like Java)
    public override string ToString()
    {
        return $"Person: {FullName}, Age: {Age}";
    }

    public string Email { get; set; } = "";

    public void HaveBirthday()
    {
        Age++;
        Console.WriteLine($"Happy Birthday {FirstName}! You are now {Age} years old.");
    }
}