using OOP;
using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Person student = new Person(); // Create an object named student from Person class 
            student.Name = "Kutay";        // Assign student's name
            student.Surname = "Özcan";     // Assign student's surname
            student.Birthday = new DateTime(2001, 9, 12); // Assign student's birthday
            
            Person student2 = new Person();
            student2.Name = "Ata";
            student2.Surname = "Arslan";
            student2.Birthday = new DateTime(2000, 2, 16);
            
            Person student3 = new Person();
            student3.Name = "Emin";
            student3.Surname = "Patır";
            student3.Birthday = new DateTime(1999, 12, 31);
            
            Person teacher = new Person();
            teacher.Name = "Bill";
            teacher.Surname = "Gates";
            teacher.Birthday = new DateTime(1955, 10, 28);
            
            // Calling PrintPerson() method to print the details of each object
            student.PrintPerson();          
            student2.PrintPerson();
            student3.PrintPerson();
            teacher.PrintPerson();

        }
    }
}

