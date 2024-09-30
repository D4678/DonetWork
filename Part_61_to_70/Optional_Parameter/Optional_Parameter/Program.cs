using System;

class Test
{
    public static void Main()
    {
        //Add(10, 20, 30, 40, 50);
        Add(10, 20, new object[] { 30, 40, 50 });
    }

    public static void Add(int firstNumber, int secondNumber, params object[] restOfNumbers) // if I intialized the params object after the first number it shown an error 
    {
        int result = firstNumber + secondNumber;
        if( restOfNumbers != null )
        {
            foreach(int i in restOfNumbers )
            {
                result += i;
            }
        }
        Console.WriteLine("Sum = " + result );
    }
}

