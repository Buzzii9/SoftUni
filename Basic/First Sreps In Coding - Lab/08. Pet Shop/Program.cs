using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double dogFoodQuantity = double.Parse(Console.ReadLine());
            double notDogFoodQuantity = double.Parse(Console.ReadLine());
            double dogFoodSum = dogFoodQuantity * 2.50;
            double notDogFoodSum = notDogFoodQuantity * 4.00;
            double allFoodSum = dogFoodSum + notDogFoodSum;

            Console.WriteLine($"{allFoodSum} lv.");

        }
    }
}
