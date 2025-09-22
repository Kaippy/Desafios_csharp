using System;
using System.Linq;

namespace Bubble_sort;

public static class Program
{
    public static void Main()
    {
        Random random = new();

        int[] numeros = new int[10];
        for (int i = 0; i < numeros.Length - 1; i++)
        {
            numeros[i] = random.Next(1, 10);
        }

        for (int x = 0; x < numeros.Length - 1; x++)
        {
            for (int y = 0; y < numeros.Length - 1; y++)
            {
                if (numeros[y] > numeros[y + 1])
                {
                    int temp = numeros[y];
                    numeros[y] = numeros[y + 1];
                    numeros[y + 1] = temp;
                }
            }
        }

        foreach (int num in numeros)
        {
            Console.WriteLine(num);
        }
    }
}