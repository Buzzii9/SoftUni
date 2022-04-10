using System;

namespace _07._Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chikenCount = int.Parse(Console.ReadLine());
            int fishCount = int.Parse(Console.ReadLine());
            int vegiterianCount = int.Parse(Console.ReadLine());
            double priceWithoutDesert = chikenCount * 10.35 + fishCount * 12.40 + vegiterianCount * 8.15;
            double desrtPrice = priceWithoutDesert * 0.20;

            Console.WriteLine($"Total: {(priceWithoutDesert + desrtPrice + 2.50):F2}");
        }
    }
}
