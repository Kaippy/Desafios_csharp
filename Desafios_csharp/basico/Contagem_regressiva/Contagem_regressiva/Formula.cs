using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contagem_regressiva;

public class Formula
{
    public static List<int> FormulaContagem(int numero)
    {
        List<int> resultado = new List<int>();
        for (int i = numero; i >= 0; i--)
        {
            resultado.Add(i);
        }

        return resultado;
    }
}