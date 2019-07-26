using System;


class SumSeconds
{
    static void Main()
    {
        int timeFirst = int.Parse(Console.ReadLine());
        int timeSecound = int.Parse(Console.ReadLine());
        int timeThird = int.Parse(Console.ReadLine());

        int totalTime = timeFirst + timeSecound + timeThird;

        int minute = totalTime / 60;
        int secound = totalTime % 60;

        if (secound < 10)
        {
            Console.WriteLine("{0}:0{1}", minute, secound);
        }
        else
        {
            Console.WriteLine("{0}:{1}", minute, secound);
        }
    }
}

