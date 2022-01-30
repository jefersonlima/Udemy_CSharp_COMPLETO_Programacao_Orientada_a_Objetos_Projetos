using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Course
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;
        public int testeThisNoConstrutor;
        public Produto()
        {
            this.Nome = null;
            this.Preco = 0.0;
            this.Quantidade = 0;
        }
        public Produto(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = 5;
        }

        public Produto(string nome, double preco, int quantidade)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }
        public Produto(string nome, double preco, int quantidade, int testeThisNoConstrutor) : this (nome, preco, quantidade)
        {
            this.testeThisNoConstrutor = testeThisNoConstrutor;
        }

        public double ValorTotalEmEstoque()
        {
            return this.Preco * this.Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            this.Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            this.Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return this.Nome 
                + ", Preço $ " 
                + this.Preco.ToString("F2", CultureInfo.InvariantCulture) 
                + ", " 
                + this.Quantidade 
                + " Unidades, Total: $ " 
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
