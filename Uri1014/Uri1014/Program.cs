using System;
using System.Globalization;

class URI1014
{

    static void Main(string[] args)
    {
        int dist;
        double comb, consumo;
        
        dist = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        comb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        consumo = dist / comb;

        Console.WriteLine(consumo.ToString("F3") + " km/l");

    }

}