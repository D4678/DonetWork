using System;

class Test
{
    static void Main()
    {
        string Name = "\"John\"";
        Console.WriteLine(Name);

        string name = "One\nTwo\nThree";
        Console.WriteLine(name);

        string NAME = @"c:\temp\data\files";    // verbatim Literal
        Console.WriteLine(NAME);
    }
}