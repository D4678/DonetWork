using System;

class Test
{
   static void Main()
    {
        int Numerator = 10;
        int Denominator = 2;

        int Result = Numerator % Denominator;
        Console.WriteLine("Result = {0}", Result);

        int Number = 10;

        bool IsNumber10 = Number == 10 ? true : false;

        //bool IsNumber10;

        //if(Number == 10)
        //{
        //    IsNumber10 = true;
        //}
        //else
        //{
        //    IsNumber10 = false;
        //}
        
        Console.WriteLine("Number is == {0}", IsNumber10);
    }
}
