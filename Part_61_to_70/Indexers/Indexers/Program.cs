using System;

public class SampleCollection
{
    private string[] arr = new string[10];

    //Define an indexer
    public string this[int index]
    {
        get
        {
            return arr[index];
        }
        set
        {
            arr[index] = value;
        }
    }
}
class Test
{
    public static void Main()
    {
        SampleCollection Sc1 = new SampleCollection();
        Sc1[0] = "John";
        Sc1[1] = "Doe";
        Console.WriteLine(Sc1[0]);
        Console.WriteLine(Sc1[1]);
        Console.WriteLine(Sc1[2]);
    }
}