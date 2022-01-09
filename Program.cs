using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the deposit sum (ex. 2500): ");
            double depositSum = double.Parse(Console.ReadLine());
            
            Console.Write("Enter the deposit deadline in months (ex. 6): ");
            int depositTerm = int.Parse(Console.ReadLine());
            if (depositTerm >= 12 && depositTerm <= 0)
            {
                Console.WriteLine("The deposit deadline has to be in the [1-12] months interval!");
            }

            Console.Write("Enter the annual interest percentage (ex. 0.2): ");
            double annualInterestRate = double.Parse(Console.ReadLine());
            if (annualInterestRate >= 100)
            {
                Console.WriteLine("The deposit term has to be in the [0 to 100%] interval!");
            }

            double sum = depositSum + depositTerm * ((depositSum * annualInterestRate) / 12);
            double accruedInterest = depositSum * (annualInterestRate / 100);
            double oneMonthInterest = accruedInterest / 12;
            double totalSum = depositSum + depositTerm * oneMonthInterest;
            double profit = totalSum - depositSum;

            Console.WriteLine("");
            Console.WriteLine("The total sum is: " + totalSum + "$");
            Console.WriteLine("Profit: " + profit + "$");           
        }
    }
}
