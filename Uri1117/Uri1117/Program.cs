using System;
using System.Globalization;

class URI1117
{

    static void Main(string[] args)
    {
        double nota1, nota2, media;

        nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);         // ler primeira nota

        while (nota1 < 0.0 || nota1 > 10.0)                                             // identificar se é válida
        {
            Console.WriteLine("nota invalida");                                         // executar se for inválida
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);     // executar se for inválida
        }

        nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);         // ler segunda nota

        while (nota2 < 0.0 || nota2 > 10.0)                                             // identificar se é válida
        {
            Console.WriteLine("nota invalida");                                         // executar se for inválida
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);     // executar se for inválida
        }

        media = (nota1 + nota2) / 2.0;                         
        Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));
    }

}