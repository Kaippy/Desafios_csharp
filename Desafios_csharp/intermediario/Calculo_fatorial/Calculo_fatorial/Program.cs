namespace Calculo_fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exe = true;
            

            while(exe)
            {
                Console.WriteLine("Digite um número entre 2 e 10 para saber seu fatorial");
                string entrada = Console.ReadLine();
                if (int.TryParse(entrada, out int valor))
                {
                    int valorTemp = valor;
                    int resultado = valor;
                    if (valor > 1 && valor < 11)
                    {
                        while(valorTemp > 1)
                        {
                            resultado =  resultado * (valorTemp - 1);
                            valorTemp--;

                        }
                        Console.WriteLine($"O fatorial de {valor} é {resultado} ");

                    }
                    else
                    {
                        Console.WriteLine("O número precisa ser entre 2 e 10");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida");
                    exe = false;
                }
            }

            
        }
    }
}
