using System;
using System.Linq;
using System.Collections.Generic;

namespace Tabuada;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Bem-vindo a tabuada");
    Inicio:
        while (true)
        {
            Console.WriteLine("Digite um número: ");
            double numero;
            string entrada = Console.ReadLine();

            if (double.TryParse(entrada, out numero))
            {

                List<double> resultado = Formula.FormulaTabuada(numero);

                foreach (double i in resultado)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Não é um número.");
                goto Sair;
            }
        }
    Sair:
        Console.WriteLine("Deseja sair? (s/n)");
        string sair = Console.ReadLine().Trim();
        if (sair == "s")
        {
            Environment.Exit(0);
        }
        else if (sair == "n")
        {
            goto Inicio;
        }
        else
        {
            Console.WriteLine("Entrada Inválida");
            goto Sair;
        }

    }
}