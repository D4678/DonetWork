using System;


class Program
{
    // This method will be executed by a new thread
    static void PrintNumbers()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Number: {i}");
            Thread.Sleep(1000); // Simulate some work
        }
    }

    static void Main(string[] args)
    {
        // Create a new thread to run the PrintNumbers method
        Thread newThread = new Thread(PrintNumbers);

        // Start the thread
        newThread.Start();

        // The main thread continues while the new thread runs
        Console.WriteLine("Main thread is free to do other work...");

        // Wait for the new thread to finish
        newThread.Join();

        Console.WriteLine("New thread has finished executing.");
    }
}
