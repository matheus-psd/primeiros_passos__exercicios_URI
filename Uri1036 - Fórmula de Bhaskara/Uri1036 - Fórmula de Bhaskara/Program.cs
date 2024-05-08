using System;
using System.Globalization;

class URI1036
{

    static void Main(string[] args)
    {

        double A, B, C, delta, x1, x2;

        string[] valores = Console.ReadLine().Split(' ');
        A = double.Parse(valores[0], CultureInfo.InvariantCulture);
        B = double.Parse(valores[1], CultureInfo.InvariantCulture);
        C = double.Parse(valores[2], CultureInfo.InvariantCulture);

        delta = Math.Pow(B, 2.0) - 4.0 * A * C;


        if (delta < 0.0 || A == 0) {
            Console.WriteLine("Impossivel calcular");
                }
        else
        {
            x1 = (-B + Math.Sqrt(delta)) / (2.0 * A);
            x2 = (-B - Math.Sqrt(delta)) / (2.0 * A);

            Console.WriteLine("R1 = " + x1.ToString("F5", CultureInfo.InvariantCulture));
            Console.WriteLine("R2 = " + x2.ToString("F5", CultureInfo.InvariantCulture));
        }

    }

}