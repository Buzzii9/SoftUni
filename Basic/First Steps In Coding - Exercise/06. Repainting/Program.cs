using System;

namespace _06._Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int workingTime = int.Parse(Console.ReadLine());
            double bag = 0.40;
            //пресмятаме цените на материалите

            double priceOfNylon = (nylon + 2) * 1.50;
            double priceOfPaint = (paint * 1.10) * 14.50;
            double priceOfThinner = thinner * 5.00;
            double totalMaterials = priceOfNylon + priceOfPaint + priceOfThinner + bag;
            double workman = totalMaterials * 0.30 * workingTime;
            // пресмятаме сумата

            double total = totalMaterials + workman;
            //отпечатваме общата сума

            Console.WriteLine(total);

        }
    }
}

