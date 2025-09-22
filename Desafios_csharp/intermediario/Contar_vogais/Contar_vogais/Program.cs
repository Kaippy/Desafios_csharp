using System;
using System.Linq;

namespace Contar_vogais;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite uma palavra ou uma frase para saber quantas vogais ela possui");
        string entrada = Console.ReadLine();
        int numVogais = 0;
        foreach (char palavra in entrada)
        {
            if (palavra == 'a' || palavra == 'e' || palavra == 'i' || palavra == 'o' || palavra == 'u')
            {
                numVogais += 1;
            }
        }
        if (entrada.Contains(" ") && numVogais == 0)
        {
            Console.WriteLine($"A frase \"{entrada}\" não possui vogais");
        }
        else if (entrada.Contains(" ") && numVogais != 0)
        {
            Console.WriteLine($"A frase \"{entrada}\" possui {numVogais} vogais");
        }
        else if (numVogais == 0)
        {
            Console.WriteLine($"A palavra \"{entrada}\" não possui vogais");
        }
        else
        {
            Console.WriteLine($"A palavra \"{entrada}\" possui {numVogais} vogais");
        }


    }
}