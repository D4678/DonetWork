using ConsoleApp1;
using System;

public class Test
{
    public static void Main()
    {
        Customer C1 = new Customer();
        C1.FirstName = "Test";
        C1.LastName = "Test";
        string fullName = C1.GetFullName();
        Console.WriteLine(fullName);
    }
}