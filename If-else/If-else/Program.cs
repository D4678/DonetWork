using System;

class Test
{
    static void Main()
    {
        Console.WriteLine("Enter the Number to check the Grade");
        int StudentNumber = int.Parse(Console.ReadLine());

        if(StudentNumber < 0 || StudentNumber > 100)
        {
            Console.WriteLine("Wrong number");
        }
        else if (StudentNumber > 0 && StudentNumber < 50)
        {
            Console.WriteLine("Fail");
        }
        else if (StudentNumber >= 50 && StudentNumber < 60)
        {
            Console.WriteLine("D Grade");
        }
        else if (StudentNumber >= 60 && StudentNumber < 70)
        {
            Console.WriteLine("C Grade");
        }
        else if (StudentNumber >= 70 &&  StudentNumber < 80)
        {
            Console.WriteLine("B Grade");
        }
        else if (StudentNumber >= 80 && StudentNumber <100)
        {
            Console.WriteLine("A Grade");
        }


    }
}