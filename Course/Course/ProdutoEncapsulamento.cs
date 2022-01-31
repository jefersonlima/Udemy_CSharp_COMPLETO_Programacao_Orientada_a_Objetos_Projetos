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
        #endregion

        #region Construtores
        public ProdutoEncapsulamento()
        {
            this._nome = null;
            this._preco = 0.0;
            this._quantidade = 0;
        }
        public ProdutoEncapsulamento(string nome, double preco)
        {
            this._nome = nome;
            this._preco = preco;
            this._quantidade = 5;
        }
        public ProdutoEncapsulamento(string nome, double preco, int quantidade)
        {
            this._nome = nome;
            this._preco = preco;
            this._quantidade = quantidade;
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
        public double Preco
        {
            get { return _preco; }
        }
        public int Quantidade
        {
            get { return _quantidade; }
        }
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
            return this._preco * this._quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            this._quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            this._quantidade -= quantidade;
        }

        public override string ToString()
        {
            return this._nome
                + ", Preço $ "
                + this._preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + this._quantidade
                + " Unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
        #endregion
    }
}
