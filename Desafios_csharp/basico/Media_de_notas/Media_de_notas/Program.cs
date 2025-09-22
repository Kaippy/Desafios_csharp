using System;
using System.Linq;

namespace Media_de_notas;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Média de notas");
        double media;
        string entrada1;
        string entrada2;
        string entrada3;
        double nota1;
        double nota2;
        double nota3;

        Console.Write("Digite a primeira nota: ");
        entrada1 = Console.ReadLine();
        if (double.TryParse(entrada1, out nota1))
        {
            Console.Write("Digite a segunda nota: ");
            entrada2 = Console.ReadLine();
            if (double.TryParse(entrada2, out nota2))
            {
                Console.Write("Digite a terceira nota: ");
                entrada3 = Console.ReadLine();
                if (double.TryParse(entrada3, out nota3))
                {
                    media = (nota1 + nota2 + nota3) / 3;
                    Console.WriteLine(media);
                }
                else
                {
                    Console.WriteLine("Entrada Imválida");
                }
            }
            else
            {
                Console.WriteLine("Entrada Imválida");
            }
        }
        else
        {
            Console.WriteLine("Entrada Imválida");
        }
    }
}