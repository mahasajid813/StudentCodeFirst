// See https://aka.ms/new-console-template for more information
using StudentCodeFirst;

using (var context = new StudentContext())
{
    context.Database.EnsureCreated();

    var student = new Student
    {
        StudentName = "Maha"
    };

    context.Students.Add(student);
    context.SaveChanges();

    Console.WriteLine("Student added successfully!");
}