namespace Abstraction;

public abstract class Employee // Abstract Base Class
{
    // Common properties for all employees
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? Department { get; set; }
    public abstract void Task(); // Abstract method to be implemented by derived classes
}

public class ProjectManager : Employee // Derived class for ProjectManager
{
    public override void Task() // Override Task() method for ProjectManager
    {
        Console.WriteLine($"{Name} {Surname}: Working as Project Manager at {Department}");
    }
}

public class SoftwareDeveloper : Employee // Derived class for SoftwareDeveloper
{
    public override void Task() // Override Task() class for SoftwareDeveloper
    {
        Console.WriteLine($"{Name} {Surname}: Working as Software Developer at {Department}");
    }
}

public class SalesManager : Employee // Derived class for SalesManager
{
    public override void Task() // Override Task() class for SalesManager
    {
        Console.WriteLine($"{Name} {Surname}: Working as Sales Manager at {Department}");
    }
}