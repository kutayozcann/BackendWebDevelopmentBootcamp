using LinqGroupJoin;

// Create a list of students
var students = new List<Student>()
{
    new Student() { StudentId = 1, StudentName = "Ali", ClassId = 1 },
    new Student() { StudentId = 2, StudentName = "Ayşe", ClassId = 2 },
    new Student() { StudentId = 3, StudentName = "Mehmet", ClassId = 1 },
    new Student() { StudentId = 4, StudentName = "Fatma", ClassId = 3 },
    new Student() { StudentId = 5, StudentName = "Ahmet", ClassId = 2 }
};

// Create a list for classes
var classes = new List<Class>()
{
    new Class() { ClassId = 1, ClassName = "Matematik" },
    new Class() { ClassId = 2, ClassName = "Türkçe" },
    new Class() { ClassId = 3, ClassName = "Kimya" }
};

// Perform a GroupJoin to group students by their class IDs
var query = classes.GroupJoin(students,
    c => c.ClassId,
    s => s.ClassId,
    (c, cGroup) => new
    {
        ClassName = c.ClassName,
        Students = cGroup.ToList()
    }
);

// Iterate over the query results to display the classes and their students
foreach (var item in query)
{
    Console.WriteLine($"Class: {item.ClassName}");
    foreach (var student in item.Students)
    {
        Console.WriteLine($"    Student: {student.StudentName}");
    }
}