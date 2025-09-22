using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada;

public class Formula
{
    public static List<double> FormulaTabuada(double numero)
    {


        List<double> listTabuadaResultado = new List<double>();
        {
            for (int num = 0; num <= 10; num++)
            {
                double resultado = numero * num;
                listTabuadaResultado.Add(resultado);
            }

        }
        return listTabuadaResultado;



    }
}
