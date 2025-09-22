using System;
using System.Linq;
using System.Collections.Generic;

namespace Inverter_string;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite uma palavra para vê-la ao contrário");
        string palavra = Console.ReadLine();
        string novaPalavra = "";
        for (int i = palavra.Length - 1; i >= 0; i--)
        {

            novaPalavra += palavra[i];
        }
        Console.WriteLine(novaPalavra);
    }
}