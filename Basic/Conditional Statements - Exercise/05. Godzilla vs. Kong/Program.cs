using System;

namespace _05._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statistician = int.Parse(Console.ReadLine());
            double costumePrice = double.Parse(Console.ReadLine());
            double decorPrice = 0.10 * budget;
            double totalClothingPrice = costumePrice * statistician;

            if (statistician > 150)
            {
                totalClothingPrice = totalClothingPrice - (0.10 * totalClothingPrice);
            }

            double totalMoney = totalClothingPrice + decorPrice;
            double moneyLeft = budget - totalMoney;

            if (totalMoney > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(moneyLeft):f2} leva more.");
            }
            else if (totalMoney <= budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");

            }
        }
    }

}
