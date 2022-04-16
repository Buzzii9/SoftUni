using System;

namespace _07._Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double peterBudget = double.Parse(Console.ReadLine());
            double videoCardOrder = double.Parse(Console.ReadLine());
            double cpuOrder = double.Parse(Console.ReadLine());
            double ramOrder = double.Parse(Console.ReadLine());

            double videoCardPrice = 250 * videoCardOrder;
            double cpuPrice = (videoCardPrice * 0.35) * cpuOrder;
            double ramPrice = (videoCardPrice * 0.10) * ramOrder;

            double totalPrice = videoCardPrice + cpuPrice + ramPrice;

            if (videoCardOrder > cpuOrder)
            {
                totalPrice = totalPrice - (totalPrice * 0.15);
            }

            if (peterBudget >= totalPrice)
            {
                Console.WriteLine($"You have {Math.Abs(peterBudget - totalPrice):F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(peterBudget - totalPrice):F2} leva more!");
            }
        }
    }
}
