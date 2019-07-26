using System;


class Cinema_Voucher
{
    static void Main()
    {
        int valueOfVoucher = int.Parse(Console.ReadLine());
        string purchase = Console.ReadLine();

        int counterMovie = 0;
        int counterPurchases = 0;
        int currentValueOfVoucher = valueOfVoucher;
        bool noMoney = false;



        while (purchase != "End")
        {

            if (purchase.Length > 8)
            {
                currentValueOfVoucher -= purchase[0] + purchase[1];

                if (currentValueOfVoucher < 0)
                {
                    noMoney = true;
                    break;
                }
                counterMovie++;
            }
            else if (purchase.Length <= 8)
            {
                currentValueOfVoucher -= purchase[0];

                if (currentValueOfVoucher < 0)
                {
                    noMoney = true;
                    break;
                }

                counterPurchases++;
            }
            if (noMoney)
            {
                break;
            }

            purchase = Console.ReadLine();
        }

        Console.WriteLine(counterMovie);
        Console.WriteLine(counterPurchases);
    }
}
