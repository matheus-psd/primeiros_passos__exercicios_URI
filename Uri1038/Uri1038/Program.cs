using System;
using System.Globalization;

class URI1038
{

    static void Main(string[] args)
    {

        int cod, quant;
        double preco, total;

        string[] vet = Console.ReadLine().Split(' ');
        cod = int.Parse(vet[0], CultureInfo.InvariantCulture);
        quant = int.Parse(vet[1], CultureInfo.InvariantCulture);


        switch (cod)
        {
            case 1:
                preco = 4.0;
                total = preco * quant;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                break;
            case 2:
                preco = 4.5;
                total = preco * quant;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                break;
            case 3:
                preco = 5.0;
                total = preco * quant;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                break;
            case 4:
                preco = 2.0;
                total = preco * quant;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                break;
            case 5:
                preco = 1.5;
                total = preco * quant;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                break;
        }

    }
}