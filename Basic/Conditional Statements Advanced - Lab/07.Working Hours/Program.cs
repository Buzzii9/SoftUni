using System;

namespace _07.Working_Hours
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Въвеждаме час от деннощието
            int Hours = int.Parse(Console.ReadLine());

            //2. Ден от седмицата текст
            string DayOfWeek = Console.ReadLine();

            // 3.Проверява дали офисът е отворен, като работното време на офиса е от 10 - 18 часа
            if (Hours >= 10 && Hours <= 18 && DayOfWeek != "Sunday")
            {
                Console.WriteLine("open");
            }
            else
            {
                Console.WriteLine("closed");
            }
            switch (DayOfWeek)
            {
                case "Monday":
                    break;
                case "Tuesday":
                    break;
                case "Wednesday":
                    break;
                case "Thursday":
                    break;
                case "Friday":
                    break;
                case "Saturday":
                    break;
                case "Sunday":
                    break;
            }
        }
    }
}
