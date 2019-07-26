using System;

class On_Time_For_The_Exam
{
    static void Main()
    {
        int hourOfExam = int.Parse(Console.ReadLine()) * 60;
        int minuteOfExam = int.Parse(Console.ReadLine());
        int hourOfArrival = int.Parse(Console.ReadLine()) * 60;
        int minuteOfArrival = int.Parse(Console.ReadLine());

        int sumHourAndMinutesExam = hourOfExam + minuteOfExam;
        int sumHourAndMinutesArrival = hourOfArrival + minuteOfArrival;

        int result = 0;
        int hour = 0;
        int minute = 0;

        if (sumHourAndMinutesArrival <= sumHourAndMinutesExam)
        {
            result = sumHourAndMinutesExam - sumHourAndMinutesArrival;

            if (result > 30)
            {
                hour = result / 60;
                minute = result % 60;

                if (hour == 0)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{minute} minutes before the start");
                }
                else if (hour != 0 && minute < 10)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{hour}:0{minute} hours before the start");
                }
                else
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{hour}:{minute} hours before the start");
                }
            }
            else if (result <= 30)
            {
                minute = result;

                if (minute == 0)
                {
                    Console.WriteLine("On time");
                }
               else
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{minute} minutes before the start");
                }


            }

        }
        else if (sumHourAndMinutesArrival > sumHourAndMinutesExam)
        {

            result = sumHourAndMinutesArrival - sumHourAndMinutesExam;
            hour = result / 60;
            minute = result % 60;

            if (hour == 0)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{minute} minutes after the start");
            }
            else if (hour != 0 && minute < 10)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{hour}:0{minute} hours after the start");
            }
            else
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{hour}:{minute} hours after the start");
            }

        }
    }
}

