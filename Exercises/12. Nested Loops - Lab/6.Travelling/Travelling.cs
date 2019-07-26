using System;

class Travelling
{
    static void Main()
    {
        string country = Console.ReadLine();

        double budget = 0;
        double amountCollected = 0;
        double sum = 0;

        while (country != "End")
        {
            budget = double.Parse(Console.ReadLine());
            

            while (sum < budget)
            {
                amountCollected = double.Parse(Console.ReadLine());
                sum += amountCollected;

                if (sum >= budget)
                {
                    Console.WriteLine($"Going to {country}!");
                    break;
                }
            }

            sum = 0;
            country = Console.ReadLine();
        }
    }
}

