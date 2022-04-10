using System;

namespace _03._Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositPrice = double.Parse(Console.ReadLine());
            int depositMonths = int.Parse(Console.ReadLine());
            double yearInterest = double.Parse(Console.ReadLine());
            double interest = depositPrice * yearInterest / 100;
            double interestOneMonth = interest / 12;
            double total = depositPrice + (depositMonths * interestOneMonth);

          

            Console.WriteLine(total);


        }
    }
}
