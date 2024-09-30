using System;

public struct Customer
{
    //Private fields
     private int _id;
    private string _name;

    // Contructor
    public Customer(int id, string name)
    {
        this._id = id;
        this._name = name;
    }

    // Public  Properties
    public int ID
    {
        get { return this._id; }
        set { this._id = value; }
    }

    public string Name
    {
        get { return this._name; }
        set { this._name = value; }
    }

    //Methods
    public void PrintDetails()
    {
        Console.WriteLine("Id = {0} && Name = {1}", this._id, this._name);
    }

}

public class Test
{
    public static void Main()
    {
        Customer C1 = new Customer(101, "Mark");
        C1.PrintDetails();

        Customer C2 = new Customer();
        C2.ID = 1;
        C2.Name = "John";
        C2.PrintDetails();

        //ShortHand Notation 
        Customer C3 = new Customer
        {
            ID = 12,
            Name = C1.Name,
        };
        C3.PrintDetails();
    }
}