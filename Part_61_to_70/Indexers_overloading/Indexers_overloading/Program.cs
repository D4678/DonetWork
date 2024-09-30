public class SampleCollection
{
    private string[] arr = new string[100];
    private Dictionary<string, string> dict = new Dictionary<string, string>();

    // Indexer with integer parameter
    public string this[int index]
    {
        get { return arr[index]; }
        set { arr[index] = value; }
    }

    // Indexer with string parameter
    public string this[string key]
    {
        get { return dict.ContainsKey(key) ? dict[key] : null; }
        set { dict[key] = value; }
    }
}

class Program
{
    static void Main()
    {
        SampleCollection collection = new SampleCollection();

        // Using the integer indexer
        collection[0] = "Hello";
        collection[1] = "World";
        Console.WriteLine(collection[0]);  // Output: Hello
        Console.WriteLine(collection[1]);  // Output: World

        // Using the string indexer
        collection["First"] = "Hello";
        collection["Second"] = "World";
        Console.WriteLine(collection["First"]);   // Output: Hello
        Console.WriteLine(collection["Second"]);  // Output: World
    }
}
