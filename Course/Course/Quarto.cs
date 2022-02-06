using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class Quarto
    {
        public string NomeEstudante { get; set; }
        public string EmailEstudante { get; set; }
        public int NumeroQuarto { get; set; }

        public Quarto(string nomeEstudante, string emailEstudante, int numeroQuarto)
        {
            this.NomeEstudante = nomeEstudante;
            this.EmailEstudante = emailEstudante;
            this.NumeroQuarto = numeroQuarto;
        }

        public override string ToString()
        {
            return (this.NumeroQuarto) + ": " + this.NomeEstudante + ", " + this.EmailEstudante;
        }
    }
}
