using System;

namespace _09._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string e = Console.ReadLine();
            double price = 0.0;
            double totalprice = 0.0;
            double totalprice2 = 0.0;
            if (room == "room for one person")
            {
                price = 18.00;
                if (e == "positive")
                {
                    totalprice = (days - 1) * price + (days - 1) * price * 0.25;
                    Console.WriteLine("{0:F2}", totalprice);
                }

                else if (e == "negative")


                {
                    totalprice = (days - 1) * price - (days - 1) * price * 0.10;
                    Console.WriteLine("{0:F2}", totalprice);
                }

            }
            else if (room == "apartment")
            {
                price = 25.00;
                if (e == "positive")
                {
                    if (days < 10)
                    {
                        totalprice2 = (days - 1) * price; totalprice = totalprice2 - totalprice2 * 0.30;
                        Console.WriteLine("{0:F2}", (totalprice + totalprice * 0.25));
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        totalprice2 = (days - 1) * price; totalprice = totalprice2 - totalprice2 * 0.35;
                        Console.WriteLine("{0:F2}", (totalprice + totalprice * 0.25));
                    }
                    else if (days > 15)
                    {
                        totalprice2 = (days - 1) * price; totalprice = totalprice2 - totalprice2 * 0.50;
                        Console.WriteLine("{0:F2}", (totalprice + totalprice * 0.25));
                    }
                }
                else if (e == "negative")
                {

                    if (days < 10)
                    {
                        totalprice2 = (days - 1) * price; totalprice = totalprice2 - totalprice2 * 0.30;
                        Console.WriteLine("{0:F2}", (totalprice - totalprice * 0.10));
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        totalprice2 = (days - 1) * price; totalprice = totalprice2 - totalprice2 * 0.35;
                        Console.WriteLine("{0:F2}", (totalprice - totalprice * 0.10));
                    }
                    else if (days > 15)
                    {
                        totalprice2 = (days - 1) * price; totalprice = totalprice2 - totalprice2 * 0.50;
                        Console.WriteLine("{0:F2}", (totalprice - totalprice * 0.10));
                    }
                }

            }

            else if (room == "president apartment")
            {
                price = 35.00;
                if (e == "positive")
                {
                    if (days < 10)
                    {
                        totalprice2 = (days - 1) * price; totalprice = totalprice2 - totalprice2 * 0.10;
                        Console.WriteLine("{0:F2}", (totalprice + totalprice * 0.25));
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        totalprice2 = (days - 1) * price; totalprice = totalprice2 - totalprice2 * 0.15;
                        Console.WriteLine("{0:F2}", (totalprice + totalprice * 0.25));
                    }
                    else if (days > 15)
                    {
                        totalprice2 = (days - 1) * price; totalprice = totalprice2 - totalprice2 * 0.20;
                        Console.WriteLine("{0:F2}", (totalprice + totalprice * 0.25));
                    }
                }
                else if (e == "negative")
                {
                    if (days < 10)
                    {
                        totalprice2 = (days - 1) * price; totalprice = totalprice2 - totalprice2 * 0.10;
                        Console.WriteLine("{0:F2}", (totalprice - totalprice * 0.10));
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        totalprice2 = (days - 1) * price; totalprice = totalprice2 - totalprice2 * 0.15;
                        Console.WriteLine("{0:F2}", (totalprice - totalprice * 0.10));
                    }
                    else if (days > 15)
                    {
                        totalprice2 = (days - 1) * price; totalprice = totalprice2 - totalprice2 * 0.20;
                        Console.WriteLine("{0:F2}", (totalprice - totalprice * 0.10));
                    }
                }
            }
        }
    }
}
