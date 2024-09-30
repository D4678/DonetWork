using System;


class Student
{
    private string[] subject = new string[3];  // Array to store object

    // Indexer to get or set subjects by index
    public string this[int index]
    {
        get
        {
            if (index >= 0 && index < subject.Length)
            {
                return subject[index];  // Return the subject at the given index
            }
            else
            {
                return "Invalid Index";
            }
        }
        set
        {
            if (index >= 0 && index < subject.Length)
            {
                subject[index] = value;   // set the subject at the given index
            }
        }
    }
    public string[] Subjects
    {
        get { return subject; }
    }
}
class Test
{
    public static void Main()
    { 
        Student student = new Student();

        //using the indexers to set the subject

        student[0] = "Maths";
        student[1] = "science";
        student[2] = "English";

        

        //using the indexers to get the subject
        Console.WriteLine("Students Subjects");

        foreach (string subject in student.Subjects)
        {
            Console.WriteLine("Student : {0}",subject);
        }
        //Console.WriteLine("Student 1: {0}", student[0]);
        //Console.WriteLine("Student 2: {0}", student[1]);
        //Console.WriteLine("Student 3: {0}", student[2]);


    }
}