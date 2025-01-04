using System;
using Inheritance;

namespace Inhertance
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci student = new Ogrenci()
            {
                Name = "Kutay", 
                Surname = "Özcan",
                StudentId = "123456"
            };
            student.DisplayStudent();

            Ogretmen teacher = new Ogretmen()
            {
                Name = "Sertan",
                Surname = "Bozkuş",
                Salary = 1000
            };
            teacher.DisplayTeacher();
        }
    }
}

