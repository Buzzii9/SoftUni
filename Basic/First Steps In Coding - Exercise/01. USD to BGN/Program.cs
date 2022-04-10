using System;

namespace _01._USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
   
                //chetem ot console
                double usd = double.Parse(Console.ReadLine());

                //preobrazuvame usd kum bgn
                double bgn = usd * 1.79549;

                //pishem na konzolata bgn
                Console.WriteLine(bgn);
            
        }
    }
}
    