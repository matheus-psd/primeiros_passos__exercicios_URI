using System;
using System.Globalization;

class URI1021
{

    static void Main(string[] args)
    {
        double N;
        int nota, quociente, moeda, resto;

        N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // valor de entrada

        Console.WriteLine("NOTAS:"); // Início dos cálculos das notas

        resto = (int) (N * 100 + 0.5);

        nota = 100;
        quociente = resto / (nota * 100); // n° de notas de R$100
        Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
        resto = resto % (nota * 100); // O que sobrou da divisão de N pela quantidade de notas de R$100

        nota = 50;
        quociente = resto / (nota * 100); // n° de notas de R$50
        Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
        resto = resto % (nota * 100); // O que sobrou da divisão de N pela quantidade de notas de R$50

        nota = 20;
        quociente = resto / (nota * 100); // n° de notas de R$20
        Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
        resto = resto % (nota * 100); // O que sobrou da divisão de N pela quantidade de notas de R$20

        nota = 10;
        quociente = resto / (nota * 100); // n° de notas de R$10
        Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
        resto = resto % (nota * 100); // O que sobrou da divisão de N pela quantidade de notas de R$10

        nota = 5;
        quociente = resto / (nota * 100); // n° de notas de R$5
        Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
        resto = resto % (nota * 100); // O que sobrou da divisão de N pela quantidade de notas de R$5

        nota = 2;
        quociente = resto / (nota * 100); // n° de notas de R$2
        Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
        resto = resto % (nota * 100); // O que sobrou da divisão de N pela quantidade de notas de R$2


        Console.WriteLine("MOEDAS:"); // Início dos cálculos das moedas

        moeda = 100; // moeda de R$1 * 100
        quociente = resto / moeda; // n° de moedas de R$1
        Console.WriteLine(quociente + " moeda(s) de R$1.00");
        resto = resto % moeda; // O que sobrou da divisão de N pela quantidade de moedas de R$1

        moeda = 50; // moeda de R$0,50 * 100
        quociente = resto / moeda; // n° de moedas de R$0,50 
        Console.WriteLine(quociente + " moeda(s) de R$0.50");
        resto = resto % moeda; // O que sobrou da divisão de N pela quantidade de moedas de R$0,50

        moeda = 25; // moeda de R$0,25 * 100
        quociente = resto / moeda; // n° de moedas de R$0,25
        Console.WriteLine(quociente + " moeda(s) de R$0.25");
        resto = resto % moeda; // O que sobrou da divisão de N pela quantidade de moedas de R$0,25

        moeda = 10; // moeda de R$0,10 * 100
        quociente = resto / moeda; // n° de moedas de R$0,10
        Console.WriteLine(quociente + " moeda(s) de R$0.10");
        resto = resto % moeda; // O que sobrou da divisão de N pela quantidade de moedas de R$0,10

        moeda = 5; // moeda de R$0,05 * 100
        quociente = resto / moeda; // n° de moedas de R$0,05
        Console.WriteLine(quociente + " moeda(s) de R$0.05");
        resto = resto % moeda; // O que sobrou da divisão de N pela quantidade de moedas de R$0,05

        Console.WriteLine(resto + " moeda(s) de R$0.01"); // n° de moedas de R$0,01
    }

}