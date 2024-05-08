using System;
using System.Globalization;

class URI1047
{

    static void Main(string[] args)
    {

        int hora_inicio, hora_fim, minuto_inicio, minuto_fim, duracao_horas, duracao_minutos;

        string[] valores = Console.ReadLine().Split(' ');
        hora_inicio = int.Parse(valores[0]);
        minuto_inicio = int.Parse(valores[1]);
        hora_fim = int.Parse(valores[2]);
        minuto_fim = int.Parse(valores[3]);


        // Considerando cenários onde a hora inicial é maior, deduzimos que virou o dia

        if (hora_inicio > hora_fim && minuto_inicio > minuto_fim)
        {
            duracao_minutos = 60 + minuto_fim - minuto_inicio;
            duracao_horas = 24 - 1 + hora_fim - hora_inicio;
        }
        else if (hora_inicio > hora_fim && minuto_inicio == minuto_fim)
        {
            duracao_minutos = minuto_fim - minuto_inicio;
            duracao_horas = 24 + hora_fim - hora_inicio;
        }
        else if (hora_inicio > hora_fim && minuto_inicio < minuto_fim)
        {
            duracao_minutos = minuto_fim - minuto_inicio;
            duracao_horas = 24 + hora_fim - hora_inicio;
        }

        // Considerando cenários onde a hora final é maior, deduzimos que não virou o dia

        else if (hora_inicio < hora_fim && minuto_inicio > minuto_fim)
        {
            duracao_minutos = 60 + minuto_fim - minuto_inicio;
            duracao_horas = hora_fim - hora_inicio - 1;
        }
        else if (hora_inicio < hora_fim && minuto_inicio == minuto_fim)
        {
            duracao_minutos = minuto_fim - minuto_inicio;
            duracao_horas = hora_fim - hora_inicio;
        }
        else if (hora_inicio < hora_fim && minuto_inicio < minuto_fim)
        {
            duracao_minutos = minuto_fim - minuto_inicio;
            duracao_horas = hora_fim - hora_inicio;
        }

        // Considerando cenários onde a hora final e inicial são iguais, temos:

        else if (hora_inicio == hora_fim && minuto_inicio > minuto_fim)
        {
            duracao_minutos = 60 + minuto_fim - minuto_inicio;
            duracao_horas = 24 - 1;
        }
        else if (hora_inicio == hora_fim && minuto_inicio == minuto_fim)
        {
            duracao_minutos = minuto_fim - minuto_inicio;
            duracao_horas = 24;
        }
        else
                {
            duracao_minutos = minuto_fim - minuto_inicio;
            duracao_horas = hora_fim - hora_inicio;
        }
        Console.WriteLine("O JOGO DUROU " + duracao_horas + " HORA(S) E " + duracao_minutos + " MINUTO(S)");

    }
}
