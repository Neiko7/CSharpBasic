using System;


class Vacation
{
    static void Main()
    {
        double neededMoney = double.Parse(Console.ReadLine());
        double availableMoney = double.Parse(Console.ReadLine());

        int counter = 0;
        int counterTwo = 0;

        while (availableMoney < neededMoney)
        {
            string typeAction = Console.ReadLine();
            double sumAction = double.Parse(Console.ReadLine());
            counter++;

            if (typeAction == "save")
            {
                availableMoney += sumAction;
                counterTwo = 0;
            }
            else if (typeAction == "spend")
            {
                availableMoney -= sumAction;
                if (availableMoney <= 0)
                {
                    availableMoney = 0;
                }
                counterTwo++;
            }

            if (counterTwo >= 5)
            {
                break;
            }
        }

        if (counterTwo == 5)
        {
            Console.WriteLine("You can't save the money.");
            Console.WriteLine($"{counter}");
        }
        else if (availableMoney >= neededMoney)
        {
            Console.WriteLine($"You saved the money for {counter} days.");

        }

    }
}

