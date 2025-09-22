using System;
using System.Linq;
using System.Collections.Generic;

namespace Soma_matriz_2x2;

public static class Program
{
    public static void Main()
    {
        Random random = new Random();
        int posicao = 0;

        int[] posicaoM1 = new int[4];
        int[] posicaoM2 = new int[4];

        for (int x = 1; x <= 2; x++)
        {
            for (int y = 1; y <= 2; y++)
            {
                posicaoM1[posicao] = random.Next(1, 10);
                Console.Write($" {posicaoM1[posicao]} ");
                posicao++;
            }
            Console.WriteLine();

        }

        posicao = 0;
        Console.WriteLine();
        Console.WriteLine();

        for (int x = 1; x <= 2; x++)
        {
            for (int y = 1; y <= 2; y++)
            {
                posicaoM2[posicao] = random.Next(1, 10);
                Console.Write($" {posicaoM2[posicao]} ");
                posicao++;
            }
            Console.WriteLine();

        }
        posicao = 0;

        Console.WriteLine();
        Console.WriteLine("A soma das matrizes 2x2 é:");
        Console.WriteLine();
        for (int z = 1; z <= 2; z++)
        {
            for (int w = 1; w <= 2; w++)
            {
                Console.Write($" {posicaoM1[posicao] + posicaoM2[posicao]} ");
                posicao++;
            }
            Console.WriteLine();
        }
    }
}