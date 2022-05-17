﻿using System;

namespace _04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = start; i <= end; i++)
            {
                for (int n = start; n <= end; n++)
                {
                    counter++;

                    if (i + n == magicNum)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {n} = {magicNum})");
                        Environment.Exit(0);
                    }
                }
            }

            Console.WriteLine($"{counter} combinations - neither equals {magicNum}");

        }
    }
}
