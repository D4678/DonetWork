using System;
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    public static void Main()
    {
        List<Student> students = new List<Student>()
        {
                new Student { Name = "John", Age = 17 },
                new Student { Name = "Alice", Age = 22 },
                new Student { Name = "Bob", Age = 19 },
                new Student { Name = "Tom", Age = 15 },
                new Student { Name = "Jane", Age = 21 }
        };

        Console.WriteLine("using For Loop");
        foreach (var student in students)
        {
            if(student.Age > 18)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
            }
        }
        Console.WriteLine();

        Console.WriteLine("Using LINQ (Query Syntax):");
        var queryResult = from student in students
                          where student.Age > 18
                          select student;

        foreach (var student in queryResult)
        {
            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
        }
        Console.WriteLine();

        Console.WriteLine("Using LINQ (Method Syntax):");
        var MethodResult = students.Where(S => S.Name == "Bob");

        foreach (var student in MethodResult)
        {
            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
        }
    }
}
