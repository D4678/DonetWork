using System;

class Test
{
    static void Main()
    {
        //int i = null
        bool? AreYouMajor = null;

        if (AreYouMajor == true)
            Console.WriteLine("user Is Major");
        else if (AreYouMajor == false)
            Console.WriteLine("User is Not Major");
        else
            Console.WriteLine("User Did not answer the Qusetion");
    }
}