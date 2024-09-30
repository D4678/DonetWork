using System;

public class DemoException
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Enter The First Number");
            int FN = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter The Second Number");
            int SN = int.Parse(Console.ReadLine());

            int Result = FN / SN;

            Console.WriteLine(" The Result  = {0}", Result);
        } 
        catch(DivideByZeroException e)
        {
            Console.WriteLine("Plese consider the number is greter than 0");
        }
        catch(FormatException fe)
        {
            Console.WriteLine("Plese Enter The Number in correct format");
        }
        catch(Exception ex) 
        { 
            Console.WriteLine("Some Error Has been Ouuured");
        }
        Console.WriteLine("Program executed succeessfully");
    }
}