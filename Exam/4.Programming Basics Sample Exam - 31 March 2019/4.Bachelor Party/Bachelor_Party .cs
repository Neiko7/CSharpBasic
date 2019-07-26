using System;


class Bachelor_Party
{
    static void Main()
    {
        int guestPerformer = int.Parse(Console.ReadLine());
        string numberOfPeople = Console.ReadLine();

        int numOfPeople = 0;
        int sum = 0;
        int counter = 0;
        int diff = 0;
        

        while (numberOfPeople != "The restaurant is full")
        {
            numOfPeople = int.Parse(numberOfPeople);

            if (numOfPeople < 5)
            {
                sum += numOfPeople * 100;
                counter += numOfPeople;
            }
            else if (numOfPeople >= 5)
            {
                sum += numOfPeople * 70;
                counter += numOfPeople;
            }

            numberOfPeople = Console.ReadLine();
        }

        diff = Math.Abs(sum - guestPerformer);

        if (sum >= guestPerformer)
        {
            Console.WriteLine($"You have {counter} guests and {diff} leva left.");
        }
        else if (sum < guestPerformer)
        {
            Console.WriteLine($"You have {counter} guests and {sum} leva income, but no singer.");
        }
    }
}

