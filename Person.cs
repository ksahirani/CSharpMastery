namespace CSharpMastery;

public class Person(string firstName, string lastName, int age)
{
    //Properties (C# way - no more getters/setters!)
    private string FirstName { get; set; } = firstName;
    private string LastName { get; set; } = lastName;
    private int Age { get; set; } = age;

    //Read-only property (computed)
    private string FullName => $"{FirstName} {LastName}";
    
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
}