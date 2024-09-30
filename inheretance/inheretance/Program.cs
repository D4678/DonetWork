using System;


public class employee
{
    public string FirstName;
    public string lastName;
    public string Email;

    public void PrintFulName()
    {
        Console.WriteLine(FirstName + "" + lastName);
    }
}

public class FullTimeEmployee : employee
{
    public float yearlySalary;
}

public class PartTimeEmployee : employee
{
    public float Hourlyrate;
}
class Test
{
    public static void Main()
    {
        FullTimeEmployee f = new FullTimeEmployee();
        f.FirstName = "Hello";
        f.lastName = "World";
        f.yearlySalary = 2000000;
        f.PrintFulName();

        PartTimeEmployee part = new PartTimeEmployee();
        part.FirstName = "D";
        part.lastName = "m";
        part.Hourlyrate = 500;
        part.PrintFulName();
    }
}