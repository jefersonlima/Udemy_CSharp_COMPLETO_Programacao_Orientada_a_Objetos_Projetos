using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class ConversorDeMoeda
    {
        public static double ConverteDolarParaReal(double valorDolar, double quantidadeDeDolares)
        {
            double valor = (valorDolar * quantidadeDeDolares);
            valor = valor / 100 * 6 + valor;
            return valor;
        }
    }
}
