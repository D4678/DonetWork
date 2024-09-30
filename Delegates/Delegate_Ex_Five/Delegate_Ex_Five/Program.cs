using System;

delegate int Calculator(int n); // Declare a delegate

public class DelegateExample
{
     int number = 100;
    public  int Add(int n)
    {
        number = number + n;
        return number;
    }

    public  int Mul(int n)
    {
        number = number * n;
        return number;
    }

    public  int getNumber()
    {
        return number;
    }

    public static void Main()
    {
        DelegateExample example = new DelegateExample();
        Calculator C1 = new Calculator(example.Add);
        C1(5);
        Console.WriteLine("AFter C1 delegate, Number is " + example.getNumber());
        Calculator C2 = new Calculator(example.Mul);
        C2(5);
        Console.WriteLine("AFter C2 delegate, Number is " + example.getNumber());
    }
}