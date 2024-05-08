using System;
using System.Globalization;

class URI1012
{

    static void Main(string[] args)
    {
        double A, B, C, pi, triangulo, circulo, trapezio, quadrado, retangulo;
        pi = 3.14159;

        string[] valores = Console.ReadLine().Split(' ');
        A = double.Parse((valores[0]), CultureInfo.InvariantCulture);
        B = double.Parse((valores[1]), CultureInfo.InvariantCulture);
        C = double.Parse((valores[2]), CultureInfo.InvariantCulture);

        triangulo = (A * C) / 2.0;
        circulo = pi * Math.Pow(C, 2.0);
        trapezio = ((A + B) * C) / 2.0;
        quadrado = Math.Pow(B, 2.0);
        retangulo = A * B;

        Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
    }

}