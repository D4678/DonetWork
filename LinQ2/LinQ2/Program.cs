using System;

class Student
{
    public int StudentID { get; set; }
    public String StudentName { get; set; }
    public int age { get; set; }
}
public class Test
{
    public static void Main()
    {
        Student[] studentArray = {
                    new Student() { StudentID = 1, StudentName = "John", age = 18 } ,
                    new Student() { StudentID = 2, StudentName = "Steve",  age = 21 } ,
                    new Student() { StudentID = 3, StudentName = "Bill",  age = 25 } ,
                    new Student() { StudentID = 4, StudentName = "Ram" , age = 20 } ,
                    new Student() { StudentID = 5, StudentName = "Ron" , age = 31 } ,
                    new Student() { StudentID = 6, StudentName = "Chris",  age = 17 } ,
                    new Student() { StudentID = 7, StudentName = "Rob",age = 19  } ,
                };
        Student student5 = studentArray.Where(s => s.StudentID == 3).FirstOrDefault();
        if (student5 != null)
        {
            Console.WriteLine("Student with ID 3:");
            Console.WriteLine($"Name: {student5.StudentName}, Age: {student5.age}");
        }
    }
}
