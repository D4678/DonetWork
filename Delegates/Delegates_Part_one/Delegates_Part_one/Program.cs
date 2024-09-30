using System;

public delegate void HelloFunctionDelegate(string message);
class Test
{
    public static void Hello(string Strmessage)
    {
        Console.WriteLine(Strmessage);
    }
    public static void Main()
    {
        HelloFunctionDelegate del =  new HelloFunctionDelegate(Hello);
        del("Hello Delegate");
    }
}