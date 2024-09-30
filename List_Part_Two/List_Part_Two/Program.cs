using System;

class Test
{
    public static void Main()
    {
        List<String> student = new List<String>();

        student.Add("Harry");
        student.Add("Terry");
        student.Add("Parry");
        student.Add("Marry");

        Console.WriteLine("The list of students is");
        foreach(string students in student)
        {
            Console.WriteLine(students);
        }
    }
}