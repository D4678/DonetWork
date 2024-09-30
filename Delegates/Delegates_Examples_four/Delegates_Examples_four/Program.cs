using System;

delegate int Calculator(int n); // Declare a delegate

public class DelegateExample
{
    static int number = 100;
    public static int Add(int n)
    {
        number = number + n;
        return number;
    }

    public static int Mul(int n)
    {
        number = number * n;
        return number;
    }

    public static int getNumber()
    {
        return number;
    }

    public static void Main()
    {

        Calculator C1 = new Calculator(Add);
        Calculator C2 = new Calculator(Mul);
        C1(20);
        Console.WriteLine("AFter C1 delegate, Number is " + getNumber());
        C2(12);
        Console.WriteLine("AFter C2 delegate, Number is " + getNumber());
    }
}