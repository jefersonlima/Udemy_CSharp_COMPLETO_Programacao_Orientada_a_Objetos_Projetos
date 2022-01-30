using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    class Funcionario
    {
        public string Nome;
        public double Salario;

        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = (((SalarioBruto / 100) * porcentagem) + SalarioBruto);
        }

        public override string ToString()
        {
            return Nome + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
