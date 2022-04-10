using System;

namespace _04._Vacation_Books_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int pagesOfBook = int.Parse(Console.ReadLine());
            int pagesToReadForOneHour = int.Parse(Console.ReadLine());
            int daysToRead = int.Parse(Console.ReadLine());

            double HoursOfReading = pagesOfBook / pagesToReadForOneHour;
            double HoursADay = HoursOfReading / daysToRead;
            Console.WriteLine(Math.Floor(HoursADay));
        }
    }
}
