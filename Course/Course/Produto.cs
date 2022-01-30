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
        public Produto()
        {
            Nome = null;
            Preco = 0.0;
            Quantidade = 0;
        }

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 5;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome 
                + ", Preço $ " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                + ", " 
                + Quantidade 
                + " Unidades, Total: $ " 
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
