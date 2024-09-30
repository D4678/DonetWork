using System;

public class Parent
{
    public string FirstName = "FN";
    public string LastName = "LN";

    public virtual void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}

public class FullTimeEmployee:Parent
{
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + "Full Time");
    }
}
public class PartTimeEmployee : Parent
{
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + "Part Time");
    }
}
public class temporaryEmployee : Parent
{
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + "Temporaray");
    }
}

class Test
{
    public static void Main()
    {
        Parent[] employee = new Parent[4];

        employee[0] = new Parent();
        employee[1] = new FullTimeEmployee();
        employee[2] = new PartTimeEmployee();
        employee[3] = new temporaryEmployee();

        foreach(Parent i in employee)
        {
            i.PrintFullName();
        }
    }
}