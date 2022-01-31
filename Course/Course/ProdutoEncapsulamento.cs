using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Course
{
    class ProdutoEncapsulamento
    {
        #region Atributos
        private string _nome;
        public double _preco;
        public int _quantidade;
        #region Auto Properties
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }
        #endregion
        #endregion

        #region Construtores
        public ProdutoEncapsulamento()
        {
            this._nome = null;
            this.Preco = 0.0;
            this.Quantidade = 0;
        }
        public ProdutoEncapsulamento(string nome, double preco)
        {
            this._nome = nome;
            this.Preco = preco;
            this.Quantidade = 5;
        }
        public ProdutoEncapsulamento(string nome, double preco, int quantidade)
        {
            this._nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }
        #endregion

        #region Getters e Setters
        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
            else
            {
                Console.WriteLine("Nome não alterado quantidade de digitos minima inválida!");
            }  
        }
        public double GetPreco()
        {
            return _preco;
        }
        public int GetQuantidade()
        {
            return _quantidade;
        }
        #endregion

        #region Propiedades
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
                else
                {
                    Console.WriteLine("Nome não alterado, quantidade de digitos minima inválida!");
                };
            }
        }
        #endregion

        #region Metodos
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
            return this._nome
                + ", Preço $ "
                + this.Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + this.Quantidade
                + " Unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
        #endregion
    }
}
