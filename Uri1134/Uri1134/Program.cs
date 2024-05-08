using System;

class URI1134
{

    static void Main(string[] args)
    {
        int entrada, alcool, gasolina, diesel;

        entrada = int.Parse(Console.ReadLine());
        alcool = 0;
        gasolina = 0;
        diesel = 0;

        while (entrada != 4) {
            entrada = int.Parse(Console.ReadLine());
            if (entrada == 1) {
                alcool += 1;
            }
            else if (entrada == 2)
            {
                gasolina += 1;
            }
            else if (entrada == 3)
            {
                diesel += 1;
            }
        }
        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine("Alcool: " + alcool);
        Console.WriteLine("Gasolina: " + gasolina);
        Console.WriteLine("Diesel: " + diesel);
    }

}