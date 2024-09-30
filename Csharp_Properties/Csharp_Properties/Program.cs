using System;

public class Student
{
    private int _id;
    private string _name;
    private int _passMark = 35;

    public int GetPassMark()
    {
        return this._passMark;
    }

    public void SetName(string Name)
    {
        if (string.IsNullOrEmpty(Name))
        {
            throw new Exception("Name cannot be null or empty");
        }
        this._name = Name;
    }
    public string GetName()
    {
        if(string.IsNullOrEmpty(this._name))
        {
            return "no name";
        }
        else
        {
            return this._name;
        }
    }
    public void SetId(int Id)
    {
        if (Id <= 0)
        {
            throw new Exception("Student Id should not be a negative Number");
        }
        this._id = Id;
    }
    public int GetId()
    {
        return _id;
    }
}

public class Test
{
    public static void Main()
    {
        Student s = new Student();
        s.SetId(101);
        //s.SetName(null);
        Console.WriteLine("Student Id ={0}", s.GetId());
        Console.WriteLine("Student Name ={0}", s.GetName());
        Console.WriteLine("Student passmark ={0}", s.GetPassMark());


    }
}