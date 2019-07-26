using System;


class Spaceship
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double length = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double averageHeightOfAstronauts = double.Parse(Console.ReadLine());

        double volumeOfRoket = width * length * height;
        double volumeOfRoom = (averageHeightOfAstronauts + 0.40) * 2 * 2;

        double placeForAstronauts = Math.Floor(volumeOfRoket / volumeOfRoom);

        if (placeForAstronauts >= 3 && placeForAstronauts <= 10)
        {
            Console.WriteLine($"The spacecraft holds {placeForAstronauts} astronauts.");
        }
        else if (placeForAstronauts < 3)
        {
            Console.WriteLine("The spacecraft is too small.");
        }
        else if (placeForAstronauts > 10)
        {
            Console.WriteLine("The spacecraft is too big.");
        }

    }
}

