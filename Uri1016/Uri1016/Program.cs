using System;
using System.Globalization;

class URI1016
{

    static void Main(string[] args)
    {
        int dist, min;

        dist = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        min = dist * 2;

        Console.WriteLine(min + " minutos");

    }

}