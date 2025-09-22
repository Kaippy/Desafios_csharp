using System;
using System.Linq;

namespace Conversor_de_moedas;

public static class Program
{
    public static void Main()
    {
        int entrada1;
        int entrada2;
        double real1;
        double real;
        double dolar1;
        double dolar;
        double euro1;
        double euro;
        double libra1;
        double libra;
        double valor;
        double resultado;
        Console.WriteLine("Bem-vindo a conversora de moedas\n");
    Inicio:
        while (true)
            Console.WriteLine("Qual moeda você possui e deseja converter?\n");
        Console.WriteLine("1 - Real");
        Console.WriteLine("2 - Dolar");
        Console.WriteLine("3 - Euro");
        Console.WriteLine("4 - Libra");
        Console.WriteLine("Qualquer outra tecla para sair");

        entrada1 = Convert.ToInt32(Console.ReadLine());

        try(entrada1){
            if (entrada1 >= 1 && entrada1 <= 4)
            {
                switch (entrada1)
                {
                    case 1:
                        Console.WriteLine("Para qual morda gostaria de converter?\n");
                        Console.WriteLine("1 - Dolar");
                        Console.WriteLine("2 - Euro");
                        Console.WriteLine("3 - Libra");
                        entrada2 = Convert.ToInt32(Console.ReadLine());
                        try(entrada2){
                            if (entrada2 >= 1 && entrada <= 3)
                            {
                                switch (entrada2)
                                {
                                    case 1:
                                        Console.WriteLine("$ 1,00 dolar = R$ 5,42 reais");
                                        dolar = 5.42;
                                        Console.WriteLine("Digite a quantidade em reais que deseja converter");
                                        real = Convert.ToInt32(Console.ReadLine());
                                        try(real)
                                            {
                                            resultado = real * dolar;

                                        }
                                        catch (FormatException)
                                        {
                                            Console.WriteLine("Não é um número");
                                            goto Sair;
                                        }

                                        break;

                                    case 2:

                                        break;

                                    case 3:

                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Não é um número válido");
                                goto Sair;
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Nao é um número correpondente");
                            goto Sair;
                        }
                        break;

                    case 2:

                        break;

                    case 3:

                        break;

                    case 4:

                        break;
                }
            }
            else
            {
                Environment.Exit(0);
            }

        }
        catch (FormatException)
        {
            Environment.Exit(0);
        }
    Sair:
        Console.WriteLine("Deseja sair? y - sim ou qualquer tecla para continuar");
        string saida = Console.ReadLine();
        if (saida == "y")
        {
            Environment.Exit(0);
        }
        else
        {
            goto Inicio;
        }
    }
}