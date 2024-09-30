using System;

class Test
{

    public static void Main()
    {
        Console.WriteLine("starting The Methods Concept");
        Test t = new Test();
        t.Add(5, 6);

        Sub(4, 5);

    }

    public void Add(int x, int y)
    {
        int z;
        z = x + y;
        Console.WriteLine("Hello Function = {0}", z);  
    }

    public static void Sub(int x, int y)
    {
        int z;
        z = x + y;
        Console.WriteLine("Hello Function = {0}", z);
    }
}