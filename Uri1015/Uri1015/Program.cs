using System;
using System.Globalization;

class URI1015
{

    static void Main(string[] args)
    {
        double x1, x2, y1, y2, dist;

        string[] p1 = Console.ReadLine().Split(' ');
        x1 = double.Parse((p1[0]), CultureInfo.InvariantCulture);
        y1 = double.Parse((p1[1]), CultureInfo.InvariantCulture);

        string[] p2 = Console.ReadLine().Split(' ');
        x2 = double.Parse((p2[0]), CultureInfo.InvariantCulture);
        y2 = double.Parse((p2[1]), CultureInfo.InvariantCulture);

        dist = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));

        Console.WriteLine(dist.ToString("F4", CultureInfo.InvariantCulture));

    }

}