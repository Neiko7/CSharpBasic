using System;

class Trade_Commissions
{
    static void Main()
    {
        string city = Console.ReadLine().ToLower();
        double sales = double.Parse(Console.ReadLine());

        double commissionUpTo500Sofia = 0.05;
        double commissionUpTo1000Sofia = 0.07;
        double commissionUpTo10000Sofia = 0.08;
        double commissionOver10000Sofia = 0.12;

        double commissionUpTo500Plovdiv = 0.055;
        double commissionUpTo1000Plovdiv = 0.08;
        double commissionUpTo10000Plovdiv = 0.12;
        double commissionOver10000Plovdiv = 0.145;

        double commissionUpTo500Varna = 0.045;
        double commissionUpTo1000Varna = 0.075;
        double commissionUpTo10000Varna = 0.10;
        double commissionOver10000Varna = 0.13;


        double commission = -1.0;

        if (city == "sofia")
        {
            if (sales >= 0 && sales <= 500)
            {
                commission = sales * commissionUpTo500Sofia;
            }
            else if (sales > 500 && sales <= 1000)
            {
                commission = sales * commissionUpTo1000Sofia;
            }
            else if (sales > 1000 && sales <= 10000)
            {
                commission = sales * commissionUpTo10000Sofia;
            }
            else if (sales > 10000)
            {
                commission = sales * commissionOver10000Sofia;
            }
            else
            {
                Console.WriteLine("error");
            }
            if (commission > 0)
            {
                Console.WriteLine($"{commission:F2}");
            }
        }
        else if (city == "plovdiv")
        {
            if (sales >= 0 && sales <= 500)
            {
                commission = sales * commissionUpTo500Plovdiv;
            }
            else if (sales > 500 && sales <= 1000)
            {
                commission = sales * commissionUpTo1000Plovdiv;
            }
            else if (sales > 1000 && sales <= 10000)
            {
                commission = sales * commissionUpTo10000Plovdiv;
            }
            else if (sales > 10000)
            {
                commission = sales * commissionOver10000Plovdiv;
            }
            else
            {
                Console.WriteLine("error");
            }
            if (commission > 0)
            {
                Console.WriteLine($"{commission:F2}");
            }
        }
        else if (city == "varna")
        {
            if (sales >= 0 && sales <= 500)
            {
                commission = sales * commissionUpTo500Varna;
            }
            else if (sales > 500 && sales <= 1000)
            {
                commission = sales * commissionUpTo1000Varna;
            }
            else if (sales > 1000 && sales <= 10000)
            {
                commission = sales * commissionUpTo10000Varna;
            }
            else if (sales > 10000)
            {
                commission = sales * commissionOver10000Varna;
            }
            else
            {
                Console.WriteLine("error");
            }
            if (commission > 0)
            {
                Console.WriteLine($"{commission:F2}");
            }
        }
        else
        {
            Console.WriteLine("error");
        }

    }
}
