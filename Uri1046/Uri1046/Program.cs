using System;

    class URI1046
    {
    static void Main(string[] args)
    {

        int hora_inicio, hora_fim, duracao;

        string[] valores = Console.ReadLine().Split(' ');
        hora_inicio = int.Parse(valores[0]);
        hora_fim = int.Parse(valores[1]);

        if (hora_inicio > hora_fim)
        {
            duracao = 24 + hora_fim - hora_inicio;
            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
        else if (hora_inicio == hora_fim)
        {
            duracao = 24;
            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
        else
        {
            duracao = hora_fim - hora_inicio;
            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}