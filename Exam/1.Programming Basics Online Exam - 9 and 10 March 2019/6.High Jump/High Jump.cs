using System;


class High_Jump
{
    static void Main()
    {
        int desiredHeight = int.Parse(Console.ReadLine());
        int jump = 0;

        int startingHeight = desiredHeight - 30;

        int counter = 0;
        int failedCounter = 0;

        while (startingHeight - 5 < desiredHeight)
        {
            jump = int.Parse(Console.ReadLine());

            if (jump > startingHeight)
            {
                startingHeight += 5;
                counter++;
                failedCounter = 0;

            }
            else if (jump <= startingHeight)
            {
                counter++;
                failedCounter++;
            }


            if (failedCounter == 3)
            {
                Console.WriteLine($"Tihomir failed at {startingHeight}cm after {counter} jumps.");
                break;
            }
        }

        if (jump > desiredHeight)
        {
            Console.WriteLine($"Tihomir succeeded, he jumped over {desiredHeight}cm after {counter} jumps.");
        }

    }
}

