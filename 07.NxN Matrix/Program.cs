﻿namespace _07.NxN_Matrix;
class Program
{
    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        NxNMatrix(n);
    }

    static void NxNMatrix(int n)
    {
        for(int i=1;i<=n;i++)
        {
            for(int j = 1; j <= n;j++)
            {
                Console.Write($"{n} ");
            }

            Console.WriteLine();

        }
    }
}

