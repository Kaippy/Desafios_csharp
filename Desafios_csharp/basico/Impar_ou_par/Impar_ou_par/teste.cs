using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impar_ou_par;

public class Teste
{
    public static string Calculo(int numero)
    {
        string resultado;
        if (numero % 2 == 0)
        {
            resultado = "Par";
        }
        else
        {
            resultado = "Ímpar";
        }

        return resultado;
    }
}