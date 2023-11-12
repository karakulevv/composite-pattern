using CompositePattern.Interfaces;

namespace CompositePattern.Models;

// Composite
public class Department : IComponent
{
    private string name;
    private List<IComponent> employees = new List<IComponent>();

    public Department(string name)
    {
        this.name = name;
    }

    public void AddEmployee(IComponent employee)
    {
        employees.Add(employee);
    }

    public void Display()
    {
        Console.WriteLine($"Department: {name}");

        foreach (var employee in employees)
        {
            employee.Display();
        }
    }
}