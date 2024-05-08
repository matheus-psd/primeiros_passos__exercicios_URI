using System;

class URI1061
{

    static void Main(string[] args)
    {

        int dia_inicio, hora_inicio, minuto_inicio, segundo_inicio, dia_fim, hora_fim, minuto_fim, segundo_fim, dia_duracao, hora_duracao, minuto_duracao, segundo_duracao;

        string[] data_inicio = Console.ReadLine().Split(' '); // Entrada será no formato Dia XX
        dia_inicio = int.Parse(data_inicio[1]); // Extrair dia inicial

        string[] horario_inicio = Console.ReadLine().Split(' '); // Entrada será no formato hh : mm : ss
        hora_inicio = int.Parse(horario_inicio[0]); // Extrair horas
        minuto_inicio = int.Parse(horario_inicio[2]); // Extrair minutos
        segundo_inicio = int.Parse(horario_inicio[4]); // Extrair segundos

        string[] data_fim = Console.ReadLine().Split(' '); // Entrada será no formato Dia XX
        dia_fim = int.Parse(data_fim[1]); // Extrair dia final

        string[] horario_fim = Console.ReadLine().Split(' '); // Entrada será no formato hh : mm : ss
        hora_fim = int.Parse(horario_fim[0]); // Extrair horas
        minuto_fim = int.Parse(horario_fim[2]); // Extrair minutos
        segundo_fim = int.Parse(horario_fim[4]); // Extrair segundos

        int inicio = segundo_inicio + (minuto_inicio * 60) + (hora_inicio * 60 * 60) + (dia_inicio * 60 * 60 * 24); // Converter data início em segundos
        int fim = segundo_fim + (minuto_fim * 60) + (hora_fim * 60 * 60) + (dia_fim * 60 * 60 * 24); // Converter data final em segundos

        int total_segundos_evento = fim - inicio; // Duração Total do evento em segundos
        int total_minutos_evento = total_segundos_evento / 60; // Duração Total do evento em minutos
        int total_horas_evento = total_segundos_evento / 3600; // Duração Total do evento em horas

        dia_duracao = total_horas_evento / 24; 

        Console.WriteLine(dia_duracao + " dia(s)");
                
        hora_duracao = total_horas_evento % 24; // Uso de mod para obter diferença de horas

        Console.WriteLine(hora_duracao + " hora(s)");

        minuto_duracao = total_minutos_evento % 60; // Uso de mod para obter diferença de horas

        Console.WriteLine(minuto_duracao + " minuto(s)");

        segundo_duracao = total_segundos_evento % 60; // Uso de mod para obter diferença de segundos

        Console.WriteLine(segundo_duracao + " segundo(s)");

    }

}