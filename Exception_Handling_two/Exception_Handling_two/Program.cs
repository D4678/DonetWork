using System;

class Test
{
    public void show(int y)
    {
        if (y > 30)
        {
            throw new ArithmeticException("Please Enter below 30");
        }
        else
            Console.WriteLine("Your Age  = {0}", y);
    }
}

class Progran
{
    public static void Main()
    {
        int x;
         Test test = new Test();
        Console.WriteLine("Plese Enter your age below 30");
        x = int.Parse(Console.ReadLine());
        try
        {
            test.show(x);
        }
        catch(Exception e) 
        {
            Console.WriteLine(e.Message);
        }

    }
}