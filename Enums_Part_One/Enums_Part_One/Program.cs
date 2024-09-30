using System;

class Test
{
    public static void Main()
    {
        Customer[] customer = new Customer[3];

        customer[0] = new Customer
        {
            Name = "Mark",
            Gender = Gender.Male
        };
        customer[1] = new Customer
        {
            Name = "mary",
            Gender = Gender.Female
        };
        customer[2] = new Customer
        {
            Name = "bob",
            Gender = Gender.Unknown
        };
        foreach(Customer customer1 in customer)
        {
            Console.WriteLine("name = {0} && Gender = {1}", customer1.Name, GetGender(customer1.Gender));
        }

    }

    public static string GetGender(Gender gender)
    {
        switch(gender)
        {
            case Gender.Unknown:
                return "Unknown";
            case Gender.Male:
                return "Male";
            case Gender.Female:
                return "Female";
         
   
        }
    }
}
public enum Gender
{
    Unknown,
    Male,
    Female
}

//0 - Unknown
//1- Male
//2- Female
public class Customer
{
    public string? Name { get; set; }
    public Gender Gender { get; set; }
}