using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menor_numero;

public class Formula
{
    public static double FormulaDoMenor(double numero1, double numero2, double numero3)
    {
        double[] arrayEntrada = { numero1, numero2, numero3 };
        double menor = arrayEntrada.Min();
        return menor;

    }
}