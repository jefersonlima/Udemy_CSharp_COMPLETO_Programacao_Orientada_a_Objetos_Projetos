using System;
using System.Globalization;

namespace ExercicioAula23EntradaDeDadosEmCSharp_PARTE2
{
    class Program
    {
        private static string nome;
        private static int quantidadeQuartos;
        private static double preco;
        private static string sobrenome;
        private static int idade;
        private static double altura;

        static void Main(string[] args)
        {
            PegarDados();
            Imprimir();
        }

        public static void PegarDados()
        {
            Console.WriteLine("Entre com seu nome Completo: ");
            nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa: ");
            quantidadeQuartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Coloque seu ultimo nome, idade e altura (na mesma linha)");
            string[] vet = Console.ReadLine().Split(' ');
            sobrenome = vet[0];
            idade = int.Parse(vet[1]);
            altura = double.Parse(vet[2]);
        }

        public static void Imprimir()
        {
            Console.WriteLine(nome);
            Console.WriteLine(quantidadeQuartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
        
    }
}
