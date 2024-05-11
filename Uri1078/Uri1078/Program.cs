using System;

class URI1018
{

    static void Main(string[] args)
    {
        int N, produto;
        N = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            produto = i * N;
            Console.WriteLine(i + " x " + N + " = " + produto);
        }

    }

}