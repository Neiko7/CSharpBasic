using System;


class Volleyball
{
    static void Main()
    {
        string typeYear = Console.ReadLine();
        int numberOfHolidaysPerYear = int.Parse(Console.ReadLine());
        int numberOfWeekengInTravelingToHomeTown = int.Parse(Console.ReadLine());

        double volleyballWeekendForYear = 48.0;
        double weekendInSofia = 0.0;
        double playVolleyballInFestiveDay = 0.0;
        double gamesOfWeekendsAndHoliday = 0.0;

        weekendInSofia = (volleyballWeekendForYear - numberOfWeekengInTravelingToHomeTown) * (3.0 / 4);
        playVolleyballInFestiveDay = numberOfHolidaysPerYear * (2.0 / 3);
        gamesOfWeekendsAndHoliday = weekendInSofia + numberOfWeekengInTravelingToHomeTown + playVolleyballInFestiveDay;

        if (typeYear == "leap")
        {

            gamesOfWeekendsAndHoliday *= 1.15;

        }
        

        Console.WriteLine(Math.Floor(gamesOfWeekendsAndHoliday));
    }
}
