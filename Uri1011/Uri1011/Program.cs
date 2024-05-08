using System;
using System.Globalization;

class URI1011
{

    static void Main(string[] args)
    {
        double raio, pi, volume;
        pi = 3.14159;

        raio = double.Parse(Console.ReadLine());

        volume = (4.0 / 3.0) * pi * Math.Pow(raio, 3.0);
        
        Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));
        
    }

}