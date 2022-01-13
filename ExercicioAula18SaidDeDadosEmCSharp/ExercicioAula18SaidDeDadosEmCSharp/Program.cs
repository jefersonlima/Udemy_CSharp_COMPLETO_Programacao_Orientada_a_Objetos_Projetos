using System;
using System.Globalization;

namespace ExercicioAula18SaidaDeDadosEmCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            ImprimeProduto(produto1, preco1);
            ImprimeProduto(produto2, preco2);
            Console.WriteLine();

            ImprimeRegistro(idade, codigo, genero);
            Console.WriteLine();

            ImprimeMedida(medida);
        }

        static void ImprimeProduto(string produto, double preco)
        {
            Console.WriteLine($"{produto}, cujo preço é $ {preco:F2}");
        }

        static void ImprimeRegistro(byte idade, int codigo, char genero)
        {
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
        }

        static void ImprimeMedida(double valor)
        {
            Console.WriteLine($"Medida com oito casas decimais: {valor:F8}");
            Console.WriteLine($"Arredondando (três casas decimais): {valor:F3}");
            Console.WriteLine($"Separador decimal invariant culture: {valor.ToString("F3",CultureInfo.InvariantCulture)}");
        }
    }
}
