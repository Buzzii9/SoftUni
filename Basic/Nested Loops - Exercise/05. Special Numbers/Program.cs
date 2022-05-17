using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool spec = true;
            int a;
            int b = 1;
            for (int i = 1111; i < 10000; i++)
            {
                b = i;
                while (b != 0)
                {
                    a = b % 10;
                    if (a == 0)
                    {
                        spec = false;
                        break;

                    }
                    else if (n % a == 0) b = b / 10;
                    else
                    {
                        spec = false;
                        break;
                    }

                    spec = true;
                }
                if (spec == true) Console.Write(i + " ");
            }
        }
    }
}
