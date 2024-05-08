using System;

class URI1115
{

    static void Main(string[] args)
    {
        int x, y;

        string[] entrada = (Console.ReadLine().Split(' '));
        x = int.Parse(entrada[0]);
        y = int.Parse(entrada[1]);

        while (x != 0 && y != 0)
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine("primeiro");
                entrada = (Console.ReadLine().Split(' '));
                x = int.Parse(entrada[0]);
                y = int.Parse(entrada[1]);
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("segundo");
                entrada = (Console.ReadLine().Split(' '));
                x = int.Parse(entrada[0]);
                y = int.Parse(entrada[1]);
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("terceiro");
                entrada = (Console.ReadLine().Split(' '));
                x = int.Parse(entrada[0]);
                y = int.Parse(entrada[1]);
            }
            else
            {
                Console.WriteLine("quarto");
                entrada = (Console.ReadLine().Split(' '));
                x = int.Parse(entrada[0]);
                y = int.Parse(entrada[1]);
            }
        }
    }

}