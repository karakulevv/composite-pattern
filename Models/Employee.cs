using CompositePattern.Interfaces;

namespace CompositePattern.Models;

// Leaf
/// <summary>
/// Leaf - implements the behavior defined by the Component interface
/// </summary>
public class Employee : IComponent
{
    private string name;

    public Employee(string name)
    {
        this.name = name;
    }

    public void Display()
    {
        Console.WriteLine($"Employee: {name}");
    }
}