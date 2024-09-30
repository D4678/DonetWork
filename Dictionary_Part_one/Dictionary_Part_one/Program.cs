using System;
using System.Collections.Generic;
class Test
{
    public static void Main()
    {
        //Creating a Dictionary with stringkey and int values
        Dictionary<string,int> students = new Dictionary<string,int>();

        //Adding key value pair in dictionary
        students.Add("Alice", 22);
        students.Add("Bob", 20);
        students.Add("Marry", 23);

        //Accesing a value using key
        Console.WriteLine("Bob Age :" + students["Bob"]);

        // Check if the key exists
        if(students.ContainsKey("Marry"))
        {
            Console.WriteLine("Marry Age : " + students["Marry"]);
        }
        else
        {
            Console.WriteLine("key Is Not Present");
        }

        // Iterating over the dictionary
        foreach(KeyValuePair<string,int> student in students)
        {
            Console.WriteLine(student.Key + " is  " +  student.Value + "  years Old ");
        }

        //Removing an entry from dictionary
        students.Remove("marry");

        // Checking the number of entries in the dictionary
        Console.WriteLine("Total students: " + students.Count);
    }
}

