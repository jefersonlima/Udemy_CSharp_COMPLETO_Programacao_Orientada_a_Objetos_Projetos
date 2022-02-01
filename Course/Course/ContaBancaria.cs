using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Course
{
    class ContaBancaria
    {
        #region Atributos Privados
        public int NumeroConta { get; }
        public string NomeTitular { get; private set; }
        public double Saldo { get; private set; }

        public double TaxaSaque = 5.00;
        #endregion

        #region Propriedades autoImplementadas

        #endregion

        #region Construtores
        public ContaBancaria(int numeroConta, string nomeTitular)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            Saldo = 0;
        }

        public ContaBancaria(int numeroConta, string nomeTitular, double saldo) : this(numeroConta, nomeTitular)
        {
            Deposito(saldo);
        }
        #endregion

        #region Propriedades Customizadas

        #endregion

        #region Metodos da Classe
        public void Deposito(double valor)
        {
            this.Saldo += valor;
        }
        public void Saque(double valor)
        {
            if (Saldo > 0 && valor > 0 && valor <= Saldo)
            {
                Saldo = Saldo - valor - TaxaSaque;
            }
            else
            {
                Console.WriteLine("Não é possivel realizar o saque!");
                if(Saldo <= 0)
                {
                    Console.WriteLine("Saldo Insuficiente!");
                }
                else if (valor <= 0)
                {
                    Console.WriteLine("Valor digitado é invalido!");
                }
                else if (valor > Saldo)
                {
                    Console.WriteLine("Valor digitado maior que o Saldo Bancario!");
                }            
            }
        }

        public override string ToString()
        {
            return
                "DADOS DA CONTA: " +
                "\nNúmero da Conta: " + NumeroConta +
                "\nNome do Titular da conta: " + NomeTitular +
                "\nSaldo da Conta: " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
        #endregion
    }
}
