using System;

class Test
{
    static void Main()
    {
        int Totalcoffeecost = 0;
        string userDecision = string.Empty;
        do
        {
            int UserChoice = -1;
            do
            {
                Console.WriteLine("Please select your coffee Size : 1 - Small, 2 - Medium, 3- Large");
                 UserChoice = int.Parse(Console.ReadLine());

                switch (UserChoice)
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
            } while (UserChoice != 1 && UserChoice != 2 && UserChoice != 3);


            do
            {
                Console.WriteLine("Do you want to buy another coffee - Yes or No");
                userDecision = Console.ReadLine().ToUpper();

                if (userDecision != "YES" && userDecision != "NO")
                {
                    Console.WriteLine("Your Choice {0} is invalid please try again....", userDecision);
                }

            } while (userDecision != "YES" && userDecision != "NO");

        } while (userDecision.ToUpper() != "NO");

        Console.WriteLine("Thank you for shopping with us");
        Console.WriteLine("Bill Amount = {0}", Totalcoffeecost);
    }
}

