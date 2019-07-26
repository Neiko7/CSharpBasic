using System;


class Wedding_Party 
{
    static void Main()
    {
        int numberOfGuests = int.Parse(Console.ReadLine());
        double budget = int.Parse(Console.ReadLine());

        double moneyForFireworks = 0;
        double moneyForDonation = 0;

        double priceForCouvert = numberOfGuests * 20;

        double diff = Math.Abs(budget - priceForCouvert);

        if (priceForCouvert < budget)
        {
            moneyForFireworks = diff * 0.40;
            moneyForDonation = diff - moneyForFireworks;

            Console.WriteLine($"Yes! {Math.Round(moneyForFireworks)} lv are for fireworks and {Math.Round(moneyForDonation)} lv are for donation.");
        }
        else
        {
            Console.WriteLine($"They won't have enough money to pay the covert. They will need {Math.Round(diff)} lv more.");
        }

    }
}

