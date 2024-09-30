using System;

interface ICustomer
{
    void Print();
}

interface I2
{
    void I2Method();
}

class Customer : ICustomer, I2
{
    public void Print()
    {
        Console.WriteLine("Interface Method");
    }

    void I2.I2Method()
    {
        throw new NotImplementedException();
    }
}
class Test
{
    public static void Main()
    {
        Customer C1 = new Customer();
        C1.Print();

        //ICustomer C2 = new Customer();
        //C2.Print();
    }
}