using System;


class TimePlus15Minutes
{
    static void Main()
    {
        int startHour = int.Parse(Console.ReadLine());
        int startMinute = int.Parse(Console.ReadLine());

        int timeInMinute = startHour * 60 + startMinute;


        int plusMinute = 15;
        int timeSum = timeInMinute + plusMinute;


        int finishHour = timeSum / 60;
        int finishMinute = timeSum % 60;

        if (finishHour > 23)
        {
            finishHour -= 24;
        }

        if (finishMinute < 10)
        {
            Console.WriteLine("{0}:0{1}", finishHour, finishMinute);
        }
        else
        {
            Console.WriteLine("{0}:{1}", finishHour, finishMinute);
        }

    }
}
