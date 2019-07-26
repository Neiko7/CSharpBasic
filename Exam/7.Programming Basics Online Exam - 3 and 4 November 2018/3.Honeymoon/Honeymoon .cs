using System;

class Honeymoon
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        string city = Console.ReadLine();
        double numberOfNight = int.Parse(Console.ReadLine());

        double priceOfNightForTwoPeople = 0;
        double priceForNights = 0;
        double priceWithAirlineTickets = 0;
        double discount = 0;
        double diff = 0;

        if (city == "Cairo")
        {
            priceOfNightForTwoPeople = 250 * 2;

            if (numberOfNight >= 1 && numberOfNight <= 4)
            {
                priceOfNightForTwoPeople = numberOfNight * priceOfNightForTwoPeople;
                priceWithAirlineTickets = priceOfNightForTwoPeople + 600;

                discount = priceWithAirlineTickets * 0.97;
            }
            else if (numberOfNight >= 5 && numberOfNight <= 9)
            {
                priceOfNightForTwoPeople = numberOfNight * priceOfNightForTwoPeople;
                priceWithAirlineTickets = priceOfNightForTwoPeople + 600;

                discount = priceWithAirlineTickets * 0.95;
            }
            else if (numberOfNight >= 10 && numberOfNight <= 24)
            {
                priceOfNightForTwoPeople = numberOfNight * priceOfNightForTwoPeople;
                priceWithAirlineTickets = priceOfNightForTwoPeople + 600;

                discount = priceWithAirlineTickets * 0.90;
            }
            else if (numberOfNight >= 25 && numberOfNight <= 49)
            {
                priceOfNightForTwoPeople = numberOfNight * priceOfNightForTwoPeople;
                priceWithAirlineTickets = priceOfNightForTwoPeople + 600;

                discount = priceWithAirlineTickets * 0.83;
            }
            else if (numberOfNight >= 50 )
            {
                priceOfNightForTwoPeople = numberOfNight * priceOfNightForTwoPeople;
                priceWithAirlineTickets = priceOfNightForTwoPeople + 600;

                discount = priceWithAirlineTickets * 0.70;
            }
        }
        else if (city == "Paris")
        {
            priceOfNightForTwoPeople = 150 * 2;

            if (numberOfNight >= 1 && numberOfNight <= 4)
            {
                priceOfNightForTwoPeople = numberOfNight * priceOfNightForTwoPeople;
                priceWithAirlineTickets = priceOfNightForTwoPeople + 350;

                discount = priceWithAirlineTickets;
            }
            else if (numberOfNight >= 5 && numberOfNight <= 9)
            {
                priceOfNightForTwoPeople = numberOfNight * priceOfNightForTwoPeople;
                priceWithAirlineTickets = priceOfNightForTwoPeople + 350;

                discount = priceWithAirlineTickets * 0.93;
            }
            else if (numberOfNight >= 10 && numberOfNight <= 24)
            {
                priceOfNightForTwoPeople = numberOfNight * priceOfNightForTwoPeople;
                priceWithAirlineTickets = priceOfNightForTwoPeople + 350;

                discount = priceWithAirlineTickets * 0.88;
            }
            else if (numberOfNight >= 25 && numberOfNight <= 49)
            {
                priceOfNightForTwoPeople = numberOfNight * priceOfNightForTwoPeople;
                priceWithAirlineTickets = priceOfNightForTwoPeople + 350;

                discount = priceWithAirlineTickets * 0.78;
            }
            else if (numberOfNight >= 50)
            {
                priceOfNightForTwoPeople = numberOfNight * priceOfNightForTwoPeople;
                priceWithAirlineTickets = priceOfNightForTwoPeople + 350;

                discount = priceWithAirlineTickets * 0.70;
            }
        }
        else if (city == "Lima")
        {
            priceOfNightForTwoPeople = 400 * 2;

            if (numberOfNight >= 1 && numberOfNight <= 4)
            {
                priceOfNightForTwoPeople = numberOfNight * priceOfNightForTwoPeople;
                priceWithAirlineTickets = priceOfNightForTwoPeople + 850;

                discount = priceWithAirlineTickets;
            }
            else if (numberOfNight >= 5 && numberOfNight <= 9)
            {
                priceOfNightForTwoPeople = numberOfNight * priceOfNightForTwoPeople;
                priceWithAirlineTickets = priceOfNightForTwoPeople + 850;

                discount = priceWithAirlineTickets;
            }
            else if (numberOfNight >= 10 && numberOfNight <= 24)
            {
                priceOfNightForTwoPeople = numberOfNight * priceOfNightForTwoPeople;
                priceWithAirlineTickets = priceOfNightForTwoPeople + 850;

                discount = priceWithAirlineTickets;
            }
            else if (numberOfNight >= 25 && numberOfNight <= 49)
            {
                priceOfNightForTwoPeople = numberOfNight * priceOfNightForTwoPeople;
                priceWithAirlineTickets = priceOfNightForTwoPeople + 850;

                discount = priceWithAirlineTickets * 0.81;
            }
            else if (numberOfNight >= 50)
            {
                priceOfNightForTwoPeople = numberOfNight * priceOfNightForTwoPeople;
                priceWithAirlineTickets = priceOfNightForTwoPeople + 850;

                discount = priceWithAirlineTickets * 0.70;
            }
        }
        else if (city == "New York")
        {
            priceOfNightForTwoPeople = 300 * 2;

            if (numberOfNight >= 1 && numberOfNight <= 4)
            {
                priceOfNightForTwoPeople = numberOfNight * priceOfNightForTwoPeople;
                priceWithAirlineTickets = priceOfNightForTwoPeople + 650;

                discount = priceWithAirlineTickets * 0.97;
            }
            else if (numberOfNight >= 5 && numberOfNight <= 9)
            {
                priceOfNightForTwoPeople = numberOfNight * priceOfNightForTwoPeople;
                priceWithAirlineTickets = priceOfNightForTwoPeople + 650;

                discount = priceWithAirlineTickets * 0.95;
            }
            else if (numberOfNight >= 10 && numberOfNight <= 24)
            {
                priceOfNightForTwoPeople = numberOfNight * priceOfNightForTwoPeople;
                priceWithAirlineTickets = priceOfNightForTwoPeople + 650;

                discount = priceWithAirlineTickets * 0.88;
            }
            else if (numberOfNight >= 25 && numberOfNight <= 49)
            {
                priceOfNightForTwoPeople = numberOfNight * priceOfNightForTwoPeople;
                priceWithAirlineTickets = priceOfNightForTwoPeople + 650;

                discount = priceWithAirlineTickets * 0.81;
            }
            else if (numberOfNight >= 50)
            {
                priceOfNightForTwoPeople = numberOfNight * priceOfNightForTwoPeople;
                priceWithAirlineTickets = priceOfNightForTwoPeople + 650;

                discount = priceWithAirlineTickets * 0.70;
            }
        }
        else if (city == "Tokyo")
        {
            priceOfNightForTwoPeople = 350 * 2;

            if (numberOfNight >= 1 && numberOfNight <= 4)
            {
                priceOfNightForTwoPeople = numberOfNight * priceOfNightForTwoPeople;
                priceWithAirlineTickets = priceOfNightForTwoPeople + 700;

                discount = priceWithAirlineTickets;
            }
            else if (numberOfNight >= 5 && numberOfNight <= 9)
            {
                priceOfNightForTwoPeople = numberOfNight * priceOfNightForTwoPeople;
                priceWithAirlineTickets = priceOfNightForTwoPeople + 700;

                discount = priceWithAirlineTickets;
            }
            else if (numberOfNight >= 10 && numberOfNight <= 24)
            {
                priceOfNightForTwoPeople = numberOfNight * priceOfNightForTwoPeople;
                priceWithAirlineTickets = priceOfNightForTwoPeople + 700;

                discount = priceWithAirlineTickets * 0.88;
            }
            else if (numberOfNight >= 25 && numberOfNight <= 49)
            {
                priceOfNightForTwoPeople = numberOfNight * priceOfNightForTwoPeople;
                priceWithAirlineTickets = priceOfNightForTwoPeople + 700;

                discount = priceWithAirlineTickets * 0.83;
            }
            else if (numberOfNight >= 50)
            {
                priceOfNightForTwoPeople = numberOfNight * priceOfNightForTwoPeople;
                priceWithAirlineTickets = priceOfNightForTwoPeople + 700;

                discount = priceWithAirlineTickets * 0.70;
            }
        }

        diff = Math.Abs(discount - budget);

        if (discount <= budget)
        {
            Console.WriteLine($"Yes! You have {diff:F2} leva left.");
        }
        else
        {
            Console.WriteLine($"Not enough money! You need {diff:F2} leva.");
        }
    }
}

