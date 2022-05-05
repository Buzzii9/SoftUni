using System;

namespace _06._Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            int sum4 = 0;
            int sum5 = 0;
            string s = Console.ReadLine().ToLower();
            for (int i = 0; i <= s.Length - 1; i++)
            {
                if (s[i] == 'a')
                    sum1++;
                else if (s[i] == 'e')
                    sum2 += 2;
                else if (s[i] == 'i')
                    sum3 += 3;
                else if (s[i] == 'o')
                    sum4 += 4;
                else if (s[i] == 'u')
                    sum5 += 5;
            }
            int ResultSum = sum1 + sum2 + sum3 + sum4 + sum5;
            Console.WriteLine(ResultSum);
        }
    }
}
