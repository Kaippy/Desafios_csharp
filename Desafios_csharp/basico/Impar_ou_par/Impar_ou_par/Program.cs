using System;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Impar_ou_par;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Pergunte se um número é par ou ímpar");
    Inicio:
        while (true)
        {
            Console.Write("Digite um número: ");
            string entrada = Console.ReadLine();
            int numero;
            string resultado;
            if (int.TryParse(entrada, out numero))
            {
                resultado = Teste.Calculo(numero);
                Console.WriteLine(resultado);
            }
            else
            {
            Sair:
                Console.WriteLine("Entrada inválida, deseja sair? (s/n)");
                string sair = Console.ReadLine().Trim();
                if (sair == "n")
                {
                    goto Inicio;
                }
                else if (sair == "s")
                {
                    Environment.Exit(0);
                }
                else
                {
                    goto Sair;
                }
            }
        }
    }
}