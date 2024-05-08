using System;
using System.Globalization;

class URI1017
{

    static void Main(string[] args)
    {
        int tempo, vm;
        double dist, litros;

        tempo = int.Parse(Console.ReadLine());
        vm = int.Parse(Console.ReadLine());

        dist = tempo * vm;
        litros = dist / 12.0;    

        Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));

    }

}