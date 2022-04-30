using System;

namespace _12._Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            if (sales >= 0 && sales <= 500)
            {
                double comm = sales * 0.05;
                double comm1 = sales * 0.045;
                double comm2 = sales * 0.055;
                switch (city)
                {
                    case "Sofia":
                        Console.WriteLine($"{comm:f2}");
                        break;
                    case "Varna":
                        Console.WriteLine($"{comm1:f2}");
                        break;
                    case "Plovdiv":
                        Console.WriteLine($"{comm2:f2}");
                        break;
                    default:
                        Console.WriteLine("");
                        break;
                }
            }
            if (sales > 500 && sales <= 1000)
            {
                double comm = sales * 0.07;
                double comm1 = sales * 0.075;
                double comm2 = sales * 0.08;
                switch (city)
                {
                    case "Sofia":
                        Console.WriteLine($"{comm:f2}");
                        break;
                    case "Varna":
                        Console.WriteLine($"{comm1:f2}");
                        break;
                    case "Plovdiv":
                        Console.WriteLine($"{comm2:f2}");
                        break;
                    default:
                        Console.WriteLine("");
                        break;
                }
            }
            if (sales > 1000 && sales <= 10000)
            {
                double comm = sales * 0.08;
                double comm1 = sales * 0.10;
                double comm2 = sales * 0.12;
                switch (city)
                {
                    case "Sofia":
                        Console.WriteLine($"{comm:f2}");
                        break;
                    case "Varna":
                        Console.WriteLine($"{comm1:f2}");
                        break;
                    case "Plovdiv":
                        Console.WriteLine($"{comm2:f2}");
                        break;
                    default:
                        Console.WriteLine("");
                        break;
                }
            }
            if (sales > 10000)
            {
                double comm = sales * 0.12;
                double comm1 = sales * 0.13;
                double comm2 = sales * 0.145;
                switch (city)
                {
                    case "Sofia":
                        Console.WriteLine($"{comm:f2}");
                        break;
                    case "Varna":
                        Console.WriteLine($"{comm1:f2}");
                        break;
                    case "Plovdiv":
                        Console.WriteLine($"{comm2:f2}");
                        break;
                    default:
                        Console.WriteLine("");
                        break;
                }
            }
            else if (city != "Plovdiv" && city != "Sofia" && city != "Varna")
            {
                Console.WriteLine("error");
            }
            else if (sales < 0)
            {
                Console.WriteLine("error");
            }

        }
    }
}
