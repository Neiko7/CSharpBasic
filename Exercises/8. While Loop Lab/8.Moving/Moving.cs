using System;


class Moving
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        int length = int.Parse(Console.ReadLine());
        int higth = int.Parse(Console.ReadLine());
        int cartons = 0;
        int totalCarton = 0;
        int space = 0;

        int freeSpaceApartment = width * length * higth;

        string command = Console.ReadLine();

        while (command != "Done")
        {
            cartons = int.Parse(command);
            totalCarton += cartons;
            space = Math.Abs(totalCarton - freeSpaceApartment);

            if (totalCarton >= freeSpaceApartment)
            {
                Console.WriteLine($"No more free space! You need {space} Cubic meters more.");
                break;
            }

            command = Console.ReadLine();

        }

        if (command == "Done")
        {
            Console.WriteLine($"{space} Cubic meters left.");
        }
    }
}

