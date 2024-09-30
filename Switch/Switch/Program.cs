using System;

class Test
{
    static void Main()
    {
        int Totalcoffeecost = 0;

        Start:
        Console.WriteLine("Please select your coffee Size : 1 - Small, 2 - Medium, 3- Large");
        int UserChoice = int.Parse(Console.ReadLine());

        switch(UserChoice)
        {
            case 1:
                Totalcoffeecost += 1;
                break;

            case 2:
                Totalcoffeecost += 2;
                break;

            case 3: 
                Totalcoffeecost += 3;
                break;
                
            default:
                Console.WriteLine("Your Choice {0} is Invalid", UserChoice);
                break;
        }

        Decide:
        Console.WriteLine("Do you want to buy another coffee - Yes or No");
        string UserDecision = Console.ReadLine();

        switch (UserDecision.ToUpper())
        {
            case "YES":
                goto Start;

            case "NO":
                break;

            default:
                Console.WriteLine("Your Choice {0} is invalid please try again....", UserDecision);
                goto Decide;
        }

        Console.WriteLine("Thank you for shopping with us");
        Console.WriteLine("Bill Amount = {0}", Totalcoffeecost);
    }
}