using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

//Base Interface
public interface ITeacher
{
    string GetInfo();
}

//Teacher Class
public class Teacher : ITeacher
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Teacher(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string GetInfo()
    {
        return $"Teacher: {FirstName} {LastName}";
    }
}

//Classroom class => DI usage
public class Classroom
{
    private readonly ITeacher _teacher;

    public Classroom(ITeacher teacher) //Constructor Injection
    {
        _teacher = teacher;
    }

    public void GetTeacherInfo()
    {
        Console.WriteLine(_teacher.GetInfo());
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        // Dependency Injection Container
        var serviceProvider = new ServiceCollection()
            .AddTransient<ITeacher, Teacher>(provider => new Teacher("Kutay", "Özcan")).AddTransient<Classroom>()
            .BuildServiceProvider();
        
        var classroom = serviceProvider.GetService<Classroom>();
        
        classroom?.GetTeacherInfo();
    }
}