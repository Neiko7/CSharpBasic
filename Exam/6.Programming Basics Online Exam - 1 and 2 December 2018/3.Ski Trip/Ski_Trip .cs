using System;

class Ski_Trip
{
    static void Main()
    {
        int dayOfStay = int.Parse(Console.ReadLine());
        string roomType = Console.ReadLine().ToLower();
        string evaluation = Console.ReadLine().ToLower();

        double roomForOnePerson = 18.00;
        double apartment = 25.00;
        double presidentApartment = 35.00;

        double positive = 1.25;
        double negative = 0.10;

        double price = 0.0;
        double totalPrice = 0.0;

        double numberOfNights = dayOfStay - 1;

        double discountUpTo10DaysForApartment = 0.30;
        double discountUpTo15DaysForApartment = 0.35;
        double discountOver15DaysForApartment = 0.50;

        double discountUpTo10DaysForPresidentApartment = 0.10;
        double discountUpTo15DaysForPresidentApartment = 0.15;
        double discountOver15DaysForPresidentApartment = 0.20;

        if (roomType == "room for one person")
        {
            totalPrice = numberOfNights * roomForOnePerson;
        }
        else if (roomType == "apartment")
        {
            if (numberOfNights < 10)
            {
                price = numberOfNights * apartment;
                totalPrice = price - (price * discountUpTo10DaysForApartment);
            }
            else if (numberOfNights >= 10 && numberOfNights <= 15)
            {
                price = numberOfNights * apartment;
                totalPrice = price - (price * discountUpTo15DaysForApartment);
            }
            else if (numberOfNights > 15)
            {
                price = numberOfNights * apartment;
                totalPrice = price - (price * discountOver15DaysForApartment);
            }
        }
        else if (roomType == "president apartment")
        {
            if (numberOfNights < 10)
            {
                price = numberOfNights * presidentApartment;
                totalPrice = price - (price * discountUpTo10DaysForPresidentApartment);
            }
            else if (numberOfNights >= 10 && numberOfNights <= 15)
            {
                price = numberOfNights * presidentApartment;
                totalPrice = price - (price * discountUpTo15DaysForPresidentApartment);
            }
            else if (numberOfNights > 15)
            {
                price = numberOfNights * presidentApartment;
                totalPrice = price - (price * discountOver15DaysForPresidentApartment);
            }
        }

        if (evaluation == "positive")
        {
            totalPrice *= positive;
        }
        else if (evaluation == "negative")
        {
            totalPrice = totalPrice - (totalPrice * negative);
        }

        Console.WriteLine($"{totalPrice:F2}");

    }
}


