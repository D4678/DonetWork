using System;

class Test
{
    static void Main()
    {
        int[] EvenNumbers = new int[3];
        
        EvenNumbers[0] = 0;
        EvenNumbers[1] = 2;
        EvenNumbers[2] = 4;


        //Console.WriteLine(EvenNumbers[15]);
        //Program;


        for (int i = 0; i < EvenNumbers.Length; i++)
        {
            Console.WriteLine(EvenNumbers[i]);
        }

        int j = 0;
        while (j < EvenNumbers.Length)
        {
            Console.WriteLine(EvenNumbers[j]);
            j++;
        }

        foreach (int i in EvenNumbers)
        {
            Console.WriteLine(EvenNumbers[i]);
        }

    }
}
/// <summary>
/// This is the hjgjh
/// </summary>
public class Program
{

}

