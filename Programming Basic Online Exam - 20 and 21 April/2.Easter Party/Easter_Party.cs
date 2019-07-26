using System;

class Easter_Party 
{
    static void Main()
    {
        int numberOfGuests = int.Parse(Console.ReadLine());
        double pricePerBedForOnePerson = double.Parse(Console.ReadLine());
        double budget = double.Parse(Console.ReadLine());

        double discountPricePerPerson = 0.0;
        double diff = 0.0;

        if (numberOfGuests >= 10 && numberOfGuests <= 15)
        {
            discountPricePerPerson = pricePerBedForOnePerson * 0.85;
        }
        else if (numberOfGuests > 15 && numberOfGuests <= 20)
        {
            discountPricePerPerson = pricePerBedForOnePerson * 0.8;
        }
        else if (numberOfGuests > 20)
        {
            discountPricePerPerson = pricePerBedForOnePerson * 0.75;
        }
        else
        {
            discountPricePerPerson = pricePerBedForOnePerson;
        }

        double priceForCake = budget * 0.10;
        double totalSumForParty = (numberOfGuests * discountPricePerPerson) + priceForCake;

        diff = Math.Abs(budget - totalSumForParty);

        if (budget > totalSumForParty)
        {
            Console.WriteLine($"It is party time! {diff:F2} leva left.");
        }
        else
        {
            Console.WriteLine($"No party! {diff:F2} leva needed.");
        }
    }
}

