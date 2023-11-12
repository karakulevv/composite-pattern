using CompositePattern.Interfaces;
using CompositePattern.Models;

namespace CompositePattern;

static class Program
{
    public static void Main(string[] args)
    {
        // Creating individual employees
        IComponent employee1 = new Employee("John");
        IComponent employee2 = new Employee("Alice");

        // Creating a department and adding employees
        Department department = new Department("Engineering");
        department.AddEmployee(employee1);
        department.AddEmployee(employee2);

        // Displaying the department details (automatically displays employee details)
        department.Display();
    }
}