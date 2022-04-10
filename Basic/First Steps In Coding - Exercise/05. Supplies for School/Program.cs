using System;

namespace _05._Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            //4 promenlivi ot tip int (3 produkta i 1 procent)
            int pensCount = int.Parse(Console.ReadLine());
            int markersCount = int.Parse(Console.ReadLine());
            int preparatCount = int.Parse(Console.ReadLine());

            int percent = int.Parse(Console.ReadLine());

            double pensPrice = pensCount * 5.80;
            double markersPrice = markersCount * 7.20;
            double preparatPrice = preparatCount * 1.20;

            // obshtata suma
            double sum = pensPrice + markersPrice + preparatPrice;

            // ot obshtata suma vadim % sale
            double totalSum = sum - sum * (percent / 100.0);

            // pechatim result
            Console.WriteLine(totalSum);
        }
    }
}
