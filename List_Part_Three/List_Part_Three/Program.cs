using System;
using System.Reflection;

class Test
{
    public static void Main()
    {
        // Create a list of string
        List<string> fruits = new List<string>();


        //Add items to the list
        fruits.Add("Apple");
        fruits.Add("orange");
        fruits.Add("Papaya");
        fruits.Add("Grapes");
        fruits.Add("Mango");
        fruits.Add("Watermelon");



        // print All the items in the list
        Console.WriteLine("List of Fruits are:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }



    // Accessing the speecific item

    labeltry:
        try
        {
            Console.WriteLine("Enter The index Number you wnat to be Searched :");
            Boolean isParsed = int.TryParse(Console.ReadLine(), out int index);

            if (isParsed == false)
            {
                goto labeltry;
            }
            if (index >= 0 && index < fruits.Count)
            {
                Console.WriteLine($"\nThe fruit at index {index} is: " + fruits[index]);
            }
            else
            {
                // Index is out of range
                Console.WriteLine("\nYour index was not found in the list.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Please enter the valid number",ex);
            goto labeltry;
        }



        // Remove an item from the list
        //fruits.Remove("Banana");
        //Console.WriteLine("\nAfter removing 'Banana':");
        //foreach (string fruit in fruits)
        //{
        //    Console.WriteLine(fruit);
        //}


        // Count the number of items in the list
        //Console.WriteLine("\nTotal Number of fruits:" + fruits.Count);
    }
}
