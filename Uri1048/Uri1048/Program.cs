using System;
using System.Globalization;

class URI1048
{
    static void Main(string[] args)
    {

        double salario, reajuste, percentual, novo_salario;

        salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if (salario >= 0 && salario <= 400.00)
        {
           percentual = 15.0; // percentual de aumento segundo a tabela fornecida no exercício
        }
        else if (salario >= 400.01 && salario <= 800.00)
        {
            percentual = 12.0; // percentual de aumento segundo a tabela fornecida no exercício
        }
        else if (salario >= 800.01 && salario <= 1200.00)
        {
            percentual = 10.0; // percentual de aumento segundo a tabela fornecida no exercício
        }
        else if (salario >= 1200.01 && salario <= 2000.00)
        {
            percentual = 7.0; // percentual de aumento segundo a tabela fornecida no exercício
        }
        else
        {
            percentual = 4.0; // percentual de aumento segundo a tabela fornecida no exercício
        }

        novo_salario = salario + (salario * percentual / 100.0);
        Console.WriteLine("Novo salario: " + novo_salario.ToString("F2", CultureInfo.InvariantCulture));

        reajuste = novo_salario - salario; // cálculo do reajuste ganho
        Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));

        Console.WriteLine("Em percentual: " + percentual + " %"); // percentual de aumento segundo a tabela fornecida no exercício
    }
}