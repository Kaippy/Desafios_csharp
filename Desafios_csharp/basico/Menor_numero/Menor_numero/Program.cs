using System;
using System.Linq;

namespace Menor_numero;

public static class Program
{
    public static void Main()
    {
        bool execucao = true;
        while (execucao)
        {
            Console.WriteLine("Digite 3 números para saber qual é o menor");
            double numero1;
            double numero2;
            double numero3;
            string entrada1;
            string entrada2;
            string entrada3;

            Console.Write("Digite o primeiro: ");
            entrada1 = Console.ReadLine();
            Console.Write("Digite o segundo: ");
            entrada2 = Console.ReadLine();
            Console.Write("Digite o terceiro: ");
            entrada3 = Console.ReadLine();

            if (double.TryParse(entrada1, out numero1) && double.TryParse(entrada2, out numero2) && double.TryParse(entrada3, out numero3))
            {
                double resultado = Formula.FormulaDoMenor(numero1, numero2, numero3);
                Console.WriteLine(resultado);
            }
            else
            {
                Console.WriteLine("Não foi digitado uma entrada válida");
                Console.WriteLine("Deseja sair? s = sim ou qualquer outra tecla para continuar");
                string entradaSaida = Console.ReadLine();
                if (entradaSaida.ToLower() == "s")
                {
                    execucao = false;
                }
            }
        }
    }
}