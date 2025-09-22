using System;
using System.Linq;
using System.Collections.Generic;

namespace Somar_ate_N;

public static class Program
{
    public static void Main()
    {
        bool execucao = true;
        while (execucao)
        {
            int numero = 0;
            int numeroEntrada;
            Console.WriteLine("Digite um número para saber a soma de todos os númsros até ele");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out numeroEntrada))
            {
                for (int numeroProgressao = 0; numeroProgressao <= numeroEntrada; numeroProgressao++)
                {
                    numero += numeroProgressao;
                }
                Console.WriteLine(numero);

            }
            else
            {
                Console.WriteLine("Entrada inválida");
                execucao = false;
            }
        }
    }
}