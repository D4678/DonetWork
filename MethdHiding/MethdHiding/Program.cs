using System;

public class Parent
{
    public string FirstName;
    public string LastName;

    public void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}

public class Child : Parent
{
    public new void PrintFullName()
    {
        base.PrintFullName();
        Console.WriteLine(FirstName + " " + LastName + "Hello ");
    }
}
class Test
{
    public static void Main()
    {
        Child child = new Child();
        child.FirstName = "Hero";
        child.LastName = "moto";
        child.PrintFullName();
    }
}