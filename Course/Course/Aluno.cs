using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Course
{
    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public void VerificaAprovacao()
        {
            if ((Nota1 + Nota2 + Nota3) >= 60)
            {
                Console.WriteLine("APROVADO!");
            }
            else
            {
                Console.WriteLine("REPROVADO!");
                Console.WriteLine("FALTARAM {0} PONTOS", (60 -(Nota1 + Nota2 + Nota3)).ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
