using System;
using System.Globalization;

class URI1154
{

    static void Main(string[] args)
    {
        int entrada, cont;
        double idade_soma, idade_media;

        entrada = int.Parse(Console.ReadLine());
        cont = 0;
        idade_soma = 0;

        while (entrada > 0)
        {
            idade_soma += entrada;
            cont++;
            entrada = int.Parse(Console.ReadLine());
        }
        idade_media = idade_soma / cont;
        Console.WriteLine(idade_media.ToString("F2", CultureInfo.InvariantCulture));
    }

}