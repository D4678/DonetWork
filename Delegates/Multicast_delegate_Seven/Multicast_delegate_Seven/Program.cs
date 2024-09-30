using System;

public delegate void MyDelegate(string message);

public class Program
{
    // Instance method for the delegate
    public void DisplayMessage1(string message)
    {
        Console.WriteLine("Message 1: " + message);
    }

    // Instance method for the delegate
    public void DisplayMessage2(string message)
    {
        Console.WriteLine("Message 2: " + message);
    }

    // Method to demonstrate using delegates
    public void Run()
    {
        MyDelegate del = DisplayMessage1; // Assigning instance method
        del += DisplayMessage2;          // Adding another instance method

        del("Hello, Multicast Delegates!"); // Invoking delegate
    }

    // Main method to execute the program
    public static void Main()
    {
        Program program = new Program(); // Creating an instance of Program
        program.Run();                  // Calling the Run method
    }
}
