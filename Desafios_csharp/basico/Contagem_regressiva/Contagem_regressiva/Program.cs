using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;

namespace Contagem_regressiva;

public static class Program
{
    public static void Main()
    {
        bool execucao = true;
        while (execucao)
        {
            Console.WriteLine("Digite um número para a contagem regressiva");
            string entrada = Console.ReadLine();
            int numero;
            if (int.TryParse(entrada, out numero))
            {
                List<int> resultado = Formula.FormulaContagem(numero);
                foreach (int num in resultado)
                {
                    Console.WriteLine(num);
                    Thread.Sleep(1000);
                }
                execucao = false;
            }
            else
            {
                Console.WriteLine("Entrada Inválida");
                Console.WriteLine("Deseja sair? s = sim ou qualquer outra tecla para continuar");
                string saida = Console.ReadLine();
                if (saida.ToLower() == "s")
                {
                    execucao = false;
                }
            }
        }

    }
}