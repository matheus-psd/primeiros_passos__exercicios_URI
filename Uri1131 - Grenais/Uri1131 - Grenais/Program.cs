using System;

class URI1131
{

    static void Main(string[] args)
    {
        int entrada, gol_inter, gol_gremio, vitoria_inter, vitoria_gremio, empate, jogos;

        entrada = 1;
        vitoria_inter = 0;
        vitoria_gremio = 0;
        empate = 0;
        jogos = 0;

        while (entrada == 1)
        {
            jogos++;
            string[] placar = (Console.ReadLine().Split(' '));                              // ler placar do jogo
            gol_inter = int.Parse(placar[0]);                                               // qtd de gols do Inter na partida
            gol_gremio = int.Parse(placar[1]);                                              // qtd de gols do Inter na partida

            if (gol_inter > gol_gremio)                                                     // vitoria Inter
            {
                vitoria_inter++;
            }
            else if (gol_inter < gol_gremio)
            {                                              // vitoria Gremio
                vitoria_gremio++;
            }
            else                                                                            // empate
            {
                empate++;
            }

            Console.WriteLine("Novo grenal (1-sim 2-nao)");                                 // incluir novo Grenal?
            entrada = int.Parse(Console.ReadLine());

            while (entrada != 1 && entrada != 2)                                            // Se resposta for inválida
            {
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                entrada = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine(jogos + " grenais");
        Console.WriteLine("Inter:" + vitoria_inter);
        Console.WriteLine("Gremio:" + vitoria_gremio);
        Console.WriteLine("Empates:" + empate);

        if (vitoria_inter > vitoria_gremio)
        {
            Console.WriteLine("Inter venceu mais");
        }
        else if (vitoria_gremio > vitoria_inter)
        {
            Console.WriteLine("Gremio venceu mais");
        }
        else
        {
            Console.WriteLine("Nao houve vencedor");
        }
    }
}