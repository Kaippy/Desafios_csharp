using System;
using System.Linq;
using System.Collections.Generic;

namespace Array_basico;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Guardarei os nomes em segredo e mostrarei apenas a você.");
        bool execucao = true;
        string entrada;
        List<string> nomes = new List<string>();
        while (execucao)
        {

            Console.WriteLine("Deseja que eu guarde ou te mostre?");
            Console.WriteLine("g = guarde, m = mostre, s = sair");
            entrada = Console.ReadLine().ToLower();
            if (entrada == "g" || entrada == "m" || entrada == "s")
            {
                switch (entrada)
                {
                    case "g":
                        Console.Write("Escreva o nome: ");
                        entrada = Console.ReadLine();
                        nomes.Add(entrada);
                        break;
                    case "m":
                        Console.WriteLine("Aqui estão todos os nomes: ");
                        foreach (string nome in nomes)
                        {
                            Console.WriteLine(nome);
                        }
                        break;
                    case "s":
                        execucao = false;
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida");
            }

        }
    }
}