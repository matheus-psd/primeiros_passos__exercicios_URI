using System;

class URI1020
{

    static void Main(string[] args)
    {

        int N, quociente, anos, meses, dias, resto;

        N = int.Parse(Console.ReadLine());

        anos = 365;
        quociente = N / anos;
        Console.WriteLine(quociente + " ano(s)");
        resto = N % anos;

        meses = 30;
        quociente = resto / meses;
        Console.WriteLine(quociente + " mes(es)");
        dias = resto % meses;
        Console.WriteLine(dias + " dia(s)");

    }

}