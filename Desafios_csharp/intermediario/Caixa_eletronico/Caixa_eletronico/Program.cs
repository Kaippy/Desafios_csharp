using System;
using System.Linq;
using System.Collections.Generic;

namespace Caixa_eletronico;

public static class Program
{
    public static void Main()
    {
        bool exe = true;
        string entrada;
        int valor;
        int valorTemp;
        List<int> saque = new List<int>();

        int[] notas = new[]
            {
            100, 50, 20, 10, 5, 2, 1
            };

        while (exe)
        {
            Console.WriteLine("Quanto gostaria de sacar?");
            entrada = Console.ReadLine();
            if (int.TryParse(entrada, out valor) && valor > 0)
            {
                saque.Clear();
                valorTemp = valor;

                for (int i = 0; i < notas.Length; i++)
                {
                    while (valorTemp >= notas[i])
                    {
                        valorTemp -= notas[i];
                        saque.Add(notas[i]);
                    }

                }
            }
            else
            {
                Console.WriteLine("Entrada inválida");
                exe = false;
            }

            foreach (int nota in saque)
            {
                Console.WriteLine(nota);
            }
        }

    }

}
