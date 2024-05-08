using System;
using System.ComponentModel.Design;

class Uri1049
{
    static void Main(string[] args)
    {
        string n1 = Console.ReadLine();
        string n2 = Console.ReadLine();
        string n3 = Console.ReadLine();

        if (n1 == "vertebrado")
        {
            if (n2 == "ave")
            {
                if (n3 == "carnivoro")
                {
                    Console.WriteLine("aguia");
                }
                else
                {
                    Console.WriteLine("pomba");
                }
            }
            else
            {
                if (n3 == "onivoro")
                {
                    Console.WriteLine("homem");
                }
                else
                {
                    Console.WriteLine("vaca");
                }
            }
        }

        else
        {
            if (n2 == "inseto")
            {
                if (n3 == "hematofago")
                {
                    Console.WriteLine("pulga");
                }
                else
                {
                    Console.WriteLine("lagarta");
                }
            }
            else
            {
                if (n3 == "hematofago")
                {
                    Console.WriteLine("sanguessuga");
                }
                else
                {
                    Console.WriteLine("minhoca");
                }
            }
        }
    }
}


                    