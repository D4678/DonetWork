using System;

class Test
{
    public static void Main()
    {
        Tst(1,c:2);
    }

    public static void Tst(int a, int b = 10, int c = 20)
    {
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        Console.WriteLine("c = " + c);
    }
}