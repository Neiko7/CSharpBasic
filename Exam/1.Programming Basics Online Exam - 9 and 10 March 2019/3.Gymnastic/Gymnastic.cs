using System;


class Gymnastic
{
    static void Main()
    {
        string country = Console.ReadLine();
        string device = Console.ReadLine();

        double result = 0.0;
        double persent = 0.0;
        double maximalRaiting = 20;
        double remainingPoints = 0.0;

        if (country == "Russia")
        {
            if (device == "ribbon")
            {
                result = 9.100 + 9.400;
            }
            else if (device == "hoop")
            {
                result = 9.300 + 9.800;
            }
            else if (device == "rope")
            {
                result = 9.600 + 9.000;
            }
        }
        else if (country == "Bulgaria")
        {
            if (device == "ribbon")
            {
                result = 9.600 + 9.400;
            }
            else if (device == "hoop")
            {
                result = 9.550 + 9.750;
            }
            else if (device == "rope")
            {
                result = 9.500 + 9.400;
            }
        }
        else if (country == "Italy")
        {
            if (device == "ribbon")
            {
                result = 9.200 + 9.500;
            }
            else if (device == "hoop")
            {
                result = 9.450 + 9.350;
            }
            else if (device == "rope")
            {
                result = 9.700 + 9.150;
            }
        }

        remainingPoints = maximalRaiting - result;
        persent = (remainingPoints / maximalRaiting) * 100;

        Console.WriteLine($"The team of {country} get {result:F3} on {device}.");
        Console.WriteLine($"{persent:F2}%");
    }
}
