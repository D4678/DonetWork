using System;

class Customer
{
  readonly string firstName;
    string _lastName;

    public Customer()
        : this("no first name", "no last name")
    {

     }
    public Customer(string FirstName, string LastName)
    {
        this.firstName = FirstName;
        this._lastName = LastName;
    }

    public void PrintFulName()
 {
        this.firstName ="ab";
        Console.WriteLine("Full Name = {0}",this.firstName + " " + this._lastName);
    }

    ~Customer()
    {
        //This is Destructor
    }
}
class Test
{
    public static void Main()
    {
        Customer c = new Customer("Dhruv", "Maurya");
        c.PrintFulName();

        Customer c2 = new Customer();
        c2.PrintFulName();
    }

}