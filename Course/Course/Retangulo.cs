using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double CalculaAreaRetangulo()
        {
            return Largura * Altura;
        }

        public double CalculaPerimetroRetangulo()
        {
            return (Largura + Altura) * 2;
        }

        public double CalculaDiagonalRetangulo()
        {
            double diagonal = Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
            return diagonal;
        }
    }
}
