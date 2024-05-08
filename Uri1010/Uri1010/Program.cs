using System;
using System.Globalization;

class URI1010
{

    static void Main(string[] args)
    {
        int codigo1, codigo2, qtd1, qtd2;
        double valor1, valor2, pagar;

        string[] valores = Console.ReadLine().Split(' ');
        codigo1 = int.Parse(valores[0]);
        qtd1 = int.Parse(valores[1]);
        valor1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

        valores = Console.ReadLine().Split(' ');
        codigo2 = int.Parse(valores[0]);
        qtd2 = int.Parse(valores[1]);
        valor2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

        pagar = qtd1 * valor1 + qtd2 * valor2;
        Console.WriteLine("VALOR A PAGAR: R$ " + pagar.ToString("F2", CultureInfo.InvariantCulture));
    }

}