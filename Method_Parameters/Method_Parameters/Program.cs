using System;

class Test
{
    public static void Main()
    {
        // Reference Type
        /* int i = 0;
         Simple(ref i);
         Console.WriteLine(i); */

        int Total = 0;
        int Product = 0;

        Calculate(10, 20, out Total, out Product);
        Console.WriteLine("Sum = {0} && Product = {1}", Total, Product);
    }

    /*public static void Simple(ref int j)
    {
        j = 101;
    }*/
    public static void Calculate(int FN, int SN,out int Total, out int Product)
    {
        Total = FN + SN;
        Product = FN * SN;
    }
}