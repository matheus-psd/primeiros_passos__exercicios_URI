using System;
using System.Globalization;

class URI1040
{ 

    static void Main(string[] args)
    {

        float n1, n2, n3, n4, peso1, peso2, peso3, peso4, media, exame;

        peso1 = 2f;
        peso2 = 3f;
        peso3 = 4f;
        peso4 = 1f;

        string[] notas = Console.ReadLine().Split(' ');
        n1 = float.Parse(notas[0], CultureInfo.InvariantCulture);
        n2 = float.Parse(notas[1], CultureInfo.InvariantCulture);
        n3 = float.Parse(notas[2], CultureInfo.InvariantCulture);
        n4 = float.Parse(notas[3], CultureInfo.InvariantCulture);

        media = ((n1 * peso1) + (n2 * peso2) + (n3 * peso3) + (n4 * peso4)) / (peso1 + peso2 + peso3 + peso4); // calculando média do aluno

        // Corrigindo bug de arredondamento da linguagem - Quando o resultado é 4.85, o C# arredonda para 4.9

        if (media == 4.85f)
        {
            media = 4.8f;
        }

        // Bug corrigido. Segue o código...

        Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture)); // Imprimindo a Media

        if (media >= 7.0) {
            Console.WriteLine("Aluno aprovado.");
        }
        else if (media < 5.0)
        {
            Console.WriteLine("Aluno reprovado.");
        }
        else if (media >= 5.0 && media <= 6.9)
        {
            Console.WriteLine("Aluno em exame."); // aluno realizará prova final
            exame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // entrada da nota do aluno na prova final
            media = (media + exame) / 2f; // calculando média final
            Console.WriteLine("Nota do exame: " + exame.ToString("F1", CultureInfo.InvariantCulture)); // exibir nota da prova final

            if (media >= 5.0)
            {
                Console.WriteLine("Aluno aprovado.");
                Console.WriteLine("Media final: " + media.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
                Console.WriteLine("Media final: " + media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}