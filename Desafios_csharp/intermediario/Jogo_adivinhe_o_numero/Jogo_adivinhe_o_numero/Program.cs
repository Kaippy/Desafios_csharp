using System;
using System.Linq;

namespace Jogo_adivinhe_o_numero;

public static class Program
{
    public static void Main()
    {
    Inicio:
        int senha;
        Random random = new Random();
        int senhaSecreta = random.Next(0, 11);

        while (true)
        {
            Console.WriteLine("Qual é a senha? 'Um número entre 0 e 10");
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out senha))
            {
                if (senha == senhaSecreta)
                {
                    Console.WriteLine("Resposta correta!!");
                    goto jogarNovamente;
                }
            }

            else
            {
                goto Sair;
            }
        }


    Sair:
        {
            while (true)
            {
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
                }
            }


        }
    jogarNovamente:
        {

            while (true)
            {
                Console.WriteLine("Deseja jogar novamente? (s/n)");

                string jogarDeNovo = Console.ReadLine().Trim();

                if (jogarDeNovo == "s")
                {
                    goto Inicio;
                }
                else if (jogarDeNovo == "n")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Entrada Inválida");
                }
            }

        }

    }
}