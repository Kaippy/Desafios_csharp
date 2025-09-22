using System;
using System.Linq;
using System.Collections.Generic;

namespace Tabuleiro_3x3;

public static class Program
{
    public static void Main()
    {
        int posicao = 1;

        for (int y = 0; y < 3; y++)
        {

            for (int x = 0; x < 3; x++)
            {

                if (posicao == 1 || posicao == 5 || posicao == 9)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"[{posicao}] ");
                    Console.ResetColor();
                }
                else
                {
                    Console.Write($"[{posicao}] ");
                }
                posicao++;

            }
            Console.WriteLine();

        }
    }
}