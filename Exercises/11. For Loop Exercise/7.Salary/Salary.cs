using System;


class Salary
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int salary = int.Parse(Console.ReadLine());



        for (int i = 1; i <= n; i++)
        {
            string webSite = Console.ReadLine();

            if (webSite == "Facebook")
            {
                salary -= 150;
            }
            else if (webSite == "Instagram")
            {
                salary -= 100;
            }
            else if (webSite == "Reddit")
            {
                salary -= 50;
            }

            if (salary <= 0)
            {
                break;
            }
        }

        if (salary > 0)
        {
            Console.WriteLine(salary);
        }
        else
        {
            Console.WriteLine("You have lost your salary.");
        }


    }
}

