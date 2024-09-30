using System;

public delegate void MyDelegate(string message);
class Test
{
    public static void DisplayMessage1(string message)
    {
        Console.WriteLine("MESSAGE 1:  " + message);
    }

    public static void DisplayMessage2(string message)
    {
        Console.WriteLine("MESSAGE 2 :" + message);
    }
    public static void Main()
    {
        MyDelegate del = DisplayMessage1;
        del += DisplayMessage2;

        del("Hello,  Multicast Delegate");

    }
}