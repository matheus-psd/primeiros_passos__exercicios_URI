using System;
using System.Globalization;

class URI1045
{

    static void Main(string[] args)
    {


        string[] vet = Console.ReadLine().Split(' ');
        double n1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
        double n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
        double n3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

        double A, B, C;

        // Ordenando n1, n2 e n3 para descobrir A, B e C...

        if (n1 > n2 && n1 > n3) { // Caso n1 seja o maior valor
            A = n1;
            if (n2 > n3)            { // Descobrindo o segundo maior valor
                B = n2;
                C = n3;            
            }
            else            {       // Descobrindo o terceiro maior valor
                B = n3;
                C = n2;
            }
        }

        if (n2 > n1 && n2 > n3)        { // Caso n2 seja o maior valor
            A = n2;
            if (n1 > n3)            { // Descobrindo o segundo maior valor
                B = n1;
                C = n3;
            }
            else            {       // Descobrindo o terceiro maior valor
                B = n3;
                C = n1;
            }
        }

        else        { // Caso n3 seja o maior valor
            A = n3;
            if (n1 > n2)            { // Descobrindo o segundo maior valor
                B = n1;
                C = n2;
            }
            else            {       // Descobrindo o terceiro maior valor
                B = n2;
                C = n1;
            }
        }

        // Com A, B e C definidos, vamos analisar as possobilidades dadas no exercício...

        // Primeiro é preciso analisar se as medidas fornecidas podem formar um triângulo

        if (A >= B + C)
        {
            Console.WriteLine("NAO FORMA TRIANGULO");
        }

        // Agora  é preciso ver a classificação do triângulo em relação a seus ângulos internos

        else if (Math.Pow(A, 2.0) == Math.Pow(B, 2.0) + Math.Pow(C, 2.0))
        {
            Console.WriteLine("TRIANGULO RETANGULO");
        }
        else if (Math.Pow(A, 2.0) > Math.Pow(B, 2.0) + Math.Pow(C, 2.0))
        {
            Console.WriteLine("TRIANGULO OBTUSANGULO");
        }
        else
        {
            Console.WriteLine("TRIANGULO ACUTANGULO");
        }

        // Agora vamos analisar a classificação do triângulo em relação aos tamanhos dos lados

        if (A == B && B == C)
        {
            Console.WriteLine("TRIANGULO EQUILATERO");
        }
        else if (A == B || A == C || B == C)
        {
            Console.WriteLine("TRIANGULO ISOSCELES");
        }
    }
}