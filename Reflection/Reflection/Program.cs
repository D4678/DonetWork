using System;
using System.Reflection;

class Program
{
    static void Main()
    {
        Type myType = typeof(MyClass);

        // Get all public methods
        MethodInfo[] methods = myType.GetMethods();

        // Invoke a method
        MethodInfo? method = myType.GetMethod("MyMethod");

        // Create an instance of MyClass
        object? myObject = Activator.CreateInstance(myType);

        // Invoke the method with the instance as the target
        object? result = method.Invoke(myObject, new object[] { 10 });
        Console.WriteLine(result);


    }
}

class MyClass
{
    public int MyMethod(int x)
    {
        return x * 2;
    }
}