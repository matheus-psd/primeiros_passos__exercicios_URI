using System;

class URI1159
{

    static void Main(string[] args)
    {
        int x, x2, x3, x4, x5, soma;

        x = int.Parse(Console.ReadLine());

        while (x != 0)
        {
            if (x % 2 != 0)
            {
                x++;
            }
            x2 = x + 2;
            x3 = x2 + 2;
            x4 = x3 + 2;
            x5 = x4 + 2;
            soma = x + x2 + x3 + x4 + x5;

            Console.WriteLine(soma);
            x = int.Parse(Console.ReadLine());
        }
    }
}