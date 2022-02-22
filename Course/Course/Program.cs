using Course.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using Course.Entities.Enums;
using System.IO;
using Course.Entities.Exceptions;

namespace Course
{
    class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            #region Byte
            //sbyte b = sbyte.MinValue;

            //Console.WriteLine(b);
            #endregion

            #region Inteiros
            //byte n1 = 126;
            //int n2 = 1000;
            //int n3 = 2147483647;
            //long n4 = 2147483648;

            //Console.WriteLine(n1);
            //Console.WriteLine(n2);
            //Console.WriteLine(n3);
            //Console.WriteLine(n4);

            //int nm1 = int.MinValue;
            //int nm2 = int.MaxValue;

            //Console.WriteLine(nm1);
            //Console.WriteLine(nm2);
            #endregion

            #region Float / Double
            //float n5 = 4.5f; //Float precisa add o f para o c# reconhecer como float
            //double n6 = 4.5;

            //Console.WriteLine(n5);
            //Console.WriteLine(n6);
            #endregion

            #region Decimal
            //decimal d = decimal.MaxValue;

            //Console.WriteLine(d);
            #endregion

            #region Boleanos
            //bool completo = false;

            //Console.WriteLine(completo);
            #endregion

            #region Char
            //char genero = 'f';
            //char letra = '\u0041'; //pega um caracter pelo seu codigo unicode

            //Console.WriteLine(genero);
            //Console.WriteLine(letra);
            #endregion

            #region String
            //string nome = "Maria Green";

            //Console.WriteLine(nome);
            #endregion

            #region Object
            //object obj1 = "Alex Brown";
            //object obj2 = 4.5f;

            //Console.WriteLine(obj1);
            //Console.WriteLine(obj2);
            #endregion

            #region 18. Saída de dados em C#

            //#region Console.Write e Console.WriteLine
            //Console.Write("Bom dia!");
            //Console.WriteLine("Boa tarde!");
            //Console.WriteLine("Boa noite!");
            //#endregion

            //Console.WriteLine("----------------------");

            //#region Imprimindo Variáveis
            //char genero = 'F';
            //int idade = 32;
            //double saldo = 10.35784;
            //string nome = "Maria";

            //Console.WriteLine(genero);
            //Console.WriteLine(idade);
            //Console.WriteLine(saldo);
            //Console.WriteLine(nome);
            //#endregion

            //Console.WriteLine("----------------------");

            //#region Controlando casas decimais
            //Console.WriteLine(saldo.ToString("F2"));
            //Console.WriteLine(saldo.ToString("F4"));
            //Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
            //#endregion

            //Console.WriteLine("----------------------");

            //#region Placeholder
            //Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);
            //#endregion

            //#region Interpolação
            //Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
            //#endregion

            //#region Concatenação
            //Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("f2", CultureInfo.InvariantCulture) + " reais", nome, idade, saldo);
            //#endregion

            #endregion

            #region 19. Operadores de atribuição
            //int a = 10, b;
            //Console.WriteLine(a);

            //a += 2;
            //Console.WriteLine(a);

            //a *= 3;
            //Console.WriteLine(a);

            //string s = "ABC";
            //Console.WriteLine(s);

            //s += "DEF";
            //Console.WriteLine(s);

            //a = 10;
            //a++;

            //Console.WriteLine(a);

            //a = 10;
            //a--;

            //Console.WriteLine(a);

            //a = 10;
            //b = a++;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //a = 10;
            //b = ++a;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            #endregion

            #region 20. Conversão implícita e casting
            ////Conversão de float para double(casting)
            //float a = 4.5f;
            //double b = a;
            //Console.WriteLine(b);

            ////Conversão de double para float(casting)
            //double c = 5.1;
            //float d = (float)c; 
            //Console.WriteLine(d);

            ////Conversão de double para int(casting)
            //double e = 5.1;
            //int f = (int)e;
            //Console.WriteLine(f);

            ////conversão de divisão de inteiro para double
            //int g = 5;
            //int h = 2;
            //double resultado = g / h; //vai retornar um inteiro
            //Console.WriteLine(resultado);

            //resultado = (double)g / h;
            //Console.WriteLine(resultado);
            #endregion

            #region 21. Operadores aritméticos
            //int n1 = 3 + 4 * 2;
            //Console.WriteLine(n1);

            //int n2 = (3 + 4) * 2;
            //Console.WriteLine(n2);

            //int n3 = 17 % 3; //resto da divisão
            //Console.WriteLine(n3);

            //int n4 = 10 / 8;
            //Console.WriteLine(n4);
            //double n4_1 = (double)10 / 8;
            //Console.WriteLine(n4_1);
            //double n4_2 = 10.0 / 8;
            //Console.WriteLine(n4_2);

            //#region Baskara
            //double a = 1.0, b = -3.0, c = -4.0;
            ////double delta = b * b - 4.0 * a * c;
            //double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            //double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            //double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
            //Console.WriteLine(delta);
            //Console.WriteLine(x1);
            //Console.WriteLine(x2);
            //#endregion

            #endregion

            #region 22. Entrada de dados em C# - PARTE 1
            //string frase = Console.ReadLine();
            //string x = Console.ReadLine();
            //string y = Console.ReadLine();
            //string z = Console.ReadLine();

            //Console.WriteLine("Você digitou: ");
            //Console.WriteLine(frase);
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

            //#region Split
            ////string s = Console.ReadLine();
            ////string[] v = s.Split(' ');
            //string[] v = Console.ReadLine().Split(' ');
            //string a = v[0];
            //string b = v[1];
            //string c = v[2];

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //#endregion
            #endregion

            #region 23. Entrada de dados em C# - PARTE 2
            //int n1 = int.Parse(Console.ReadLine());
            ////int n1_1 = Convert.ToInt32(Console.ReadLine());
            //char ch = char.Parse(Console.ReadLine());
            //double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine(n1);
            //Console.WriteLine(ch);
            //Console.WriteLine(n2.ToString("f2", CultureInfo.InvariantCulture));

            //string[] vet = Console.ReadLine().Split(' ');

            //string nome = vet[0];
            //char sexo = char.Parse(vet[1]);
            //int idade = int.Parse(vet[2]);
            //double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            //Console.WriteLine(nome);
            //Console.WriteLine(sexo);
            //Console.WriteLine(idade);
            //Console.WriteLine(altura);
            //Console.WriteLine(altura.ToString("f2", CultureInfo.InvariantCulture));
            #endregion

            #region 25. Operadores comparativos
            //int a = 10;
            //bool c1 = a < 10;
            //bool c2 = a < 20;
            //bool c3 = a > 10;
            //bool c4 = a > 5;

            //Console.WriteLine(c1);
            //Console.WriteLine(c2);
            //Console.WriteLine(c3);
            //Console.WriteLine(c4);

            //Console.WriteLine("-------------------------");

            //bool c5 = a <= 10;
            //bool c6 = a >= 10;
            //bool c7 = a == 10;
            //bool c8 = a != 10;

            //Console.WriteLine(c5);
            //Console.WriteLine(c6);
            //Console.WriteLine(c7);
            //Console.WriteLine(c8);
            #endregion

            #region 26. Operadores lógicos
            ////AND-&&
            //bool c1 = 4 != 5;
            //Console.WriteLine(c1);

            //c1 = 2>3 && 4 != 5;
            //Console.WriteLine(c1);

            //bool c2 = !(2 > 3) && 4 != 5;
            //Console.WriteLine(c2);

            ////OR-||
            //c1 = 2 > 3 || 4 != 5;
            //Console.WriteLine(c1);

            //Console.WriteLine("----------");
            //bool c3 = 10 < 5;
            //bool c4 = c1 || c2 && c3;
            //Console.WriteLine(c4);
            #endregion

            #region 27. Estrutura condicional (if-else)
            //int x = 10;

            //Console.WriteLine("Bom dia!");
            ////if (x < 5)
            //if (x > 5)
            //{
            //    Console.WriteLine("Boa tarde!");
            //}
            //Console.WriteLine("Boa noite!");
            //Console.WriteLine("-----");
            //Console.WriteLine("Entre com um numero inteiro!");
            //int x = int.Parse(Console.ReadLine());

            //if (x % 2 == 0)
            //{
            //    Console.WriteLine("Par");
            //}
            //else
            //{
            //    Console.WriteLine("Impar");
            //}
            //Console.WriteLine("---------");
            //Console.WriteLine("qual a hora atual?");
            //int hora = int.Parse(Console.ReadLine());

            //if (hora < 12 && hora >= 5)
            //    Console.WriteLine("Bom dia!");
            //else if (hora >= 12 && hora < 18)
            //    Console.WriteLine("Boa tarde!");
            //else if (hora >= 18 && hora < 24 || (hora < 5 && hora >= 0))
            //    Console.WriteLine("Boa noite!");
            //else
            //    Console.WriteLine("Hora invalida!");
            #endregion

            #region 28. Escopo e inicialização
            //para usar uma variavel ela precisa ser inicializada!
            //int x; errado!
            //int x = 0; //correto

            //Console.WriteLine(x);

            //double preco = double.Parse(Console.ReadLine());
            //if (preco > 100.0)
            //{
            //    double desconto = preco * 0.1;
            //    Console.WriteLine(desconto); //correto 
            //}

            ////errado porquê o desconto só existe dentro do escopo do if onde ele foi criado!
            ////Console.WriteLine(desconto); //errado

            ////outra maneira é criando a variavel em um escopo maior
            //double preco2 = double.Parse(Console.ReadLine());
            //double desconto2 = 0.0;
            //if (preco > 100.0)
            //{
            //    desconto2 = preco2 * 0.1;
            //}
            //Console.WriteLine(desconto2); //errado

            #endregion

            #region 30. Funções (sintaxe)
            //Console.WriteLine("Digite três números: ");
            //int n1 = int.Parse(Console.ReadLine());
            //int n2 = int.Parse(Console.ReadLine());
            //int n3 = int.Parse(Console.ReadLine());

            //int resultado = Maior(n1, n2, n3);
            //Console.WriteLine("O maior número é: " + resultado);
            #endregion

            #region 32. Estrutura repetitiva enquanto (while)
            //double x = 0.0;
            //while (x >= 0.0) {
            //    Console.WriteLine("Digite um número: ");
            //    x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //    double raiz = Math.Sqrt(x);
            //    if (raiz >= 0.0) {
            //        Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
            //    }
            //    else
            //    {
            //        Console.WriteLine("Numero digitado negativo!");
            //    }               
            //}
            #endregion

            #region 34. Estrutura repetitiva para (for)
            //Console.WriteLine("Quantos numeros você vai digitar? ");
            //int quantidadeNumeros = int.Parse(Console.ReadLine());
            //int total = 0;
            //for (int i = 1; i <= quantidadeNumeros; i++)
            //{
            //    Console.Write("Valor #{0}: ", i);
            //    total += int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Total da soma = "+ total);
            #endregion

            #region 38. Resolvendo um problema sem orientação a objetos
            //double xA, xB, xC, yA, yB, yC, p, areaX, areaY;
            //Console.WriteLine("Entre com as medidas do triangulo X: ");
            //xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("Entre com as medidas do triangulo Y: ");
            //yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //p = (xA + xB + xC) / 2.0;
            //areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            //p = (yA + yB + yC) / 2.0;
            //areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            //Console.WriteLine("Área de x = {0}", areaX.ToString("F4", CultureInfo.InvariantCulture));
            //Console.WriteLine("Área de y = {0}", areaY.ToString("F4", CultureInfo.InvariantCulture));

            //if (areaX == areaY)
            //{
            //    Console.WriteLine("Áreas são iguais!");
            //}else if(areaX > areaY)
            //{
            //    Console.WriteLine("Maior área: X");
            //}
            //else
            //{
            //    Console.WriteLine("Maior área: Y");
            //}
            #endregion

            #region 39. Criando uma classe com três atributos para representar melhor um Triângulo
            //Triangulo x, y;
            //x = new Triangulo();
            //y = new Triangulo();

            //Console.WriteLine("Entre com as medidas do triangulo X: ");
            //x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("Entre com as medidas do triangulo Y: ");
            //y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double p, areaX, areaY;

            //p = (x.A + x.B + x.C) / 2.0;
            //areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            //p = (y.A + y.B + y.C) / 2.0;
            //areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            //Console.WriteLine("Área de x = {0}", areaX.ToString("F4", CultureInfo.InvariantCulture));
            //Console.WriteLine("Área de y = {0}", areaY.ToString("F4", CultureInfo.InvariantCulture));

            //if (areaX == areaY)
            //{
            //    Console.WriteLine("Áreas são iguais!");
            //}
            //else if (areaX > areaY)
            //{
            //    Console.WriteLine("Maior área: X");
            //}
            //else
            //{
            //    Console.WriteLine("Maior área: Y");
            //}
            #endregion

            #region 40. Primeiros exercícios (classes, objetos e atributos)

            #region Exercicio 1
            //Pessoa pessoa1;
            //Pessoa pessoa2;

            //pessoa1 = new Pessoa();
            //pessoa2 = new Pessoa();

            //Console.WriteLine("Dados da primeira pessoa: ");
            //Console.Write("Nome: ");
            //pessoa1.Nome = Console.ReadLine();
            //Console.Write("Idade: ");
            //pessoa1.Idade = int.Parse(Console.ReadLine());
            //Console.WriteLine("Dados da segunda pessoa: ");
            //Console.Write("Nome: ");
            //pessoa2.Nome = Console.ReadLine();
            //Console.Write("Idade: ");
            //pessoa2.Idade = int.Parse(Console.ReadLine());

            //if (pessoa1.Idade == pessoa2.Idade)
            //{
            //    Console.WriteLine("Tem a mesma idade!");
            //}
            //else if (pessoa1.Idade > pessoa2.Idade)
            //{
            //    Console.WriteLine("Pessoa mais velha: {0}", pessoa1.Nome);
            //}
            //else
            //{
            //    Console.WriteLine("Pessoa mais velha: {0}", pessoa2.Nome);
            //}
            #endregion

            #region Exercicio 2
            //Funcionario funcionario1 = new Funcionario();
            //Funcionario funcionario2 = new Funcionario();

            //Console.WriteLine("Dados do primeiro funcionario");
            //Console.Write("Nome: ");
            //funcionario1.Nome = Console.ReadLine();
            //Console.Write("Salário: ");
            //funcionario1.Salario = double.Parse(Console.ReadLine());

            //Console.WriteLine("Dados do segundo funcionario");
            //Console.Write("Nome: ");
            //funcionario2.Nome = Console.ReadLine();
            //Console.Write("Salário: ");
            //funcionario2.Salario = double.Parse(Console.ReadLine());

            //Console.WriteLine("Sálario médio: {0}", ((funcionario1.Salario + funcionario2.Salario)/2).ToString("F2", CultureInfo.InvariantCulture));
            #endregion

            #endregion

            #region 41. Criando um método para obtermos os benefícios de reaproveitamento e delegação
            //Triangulo x, y;
            //x = new Triangulo();
            //y = new Triangulo();

            //Console.WriteLine("Entre com as medidas do triangulo X: ");
            //x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("Entre com as medidas do triangulo Y: ");
            //y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double areaX, areaY;

            //areaX = x.AreaTrinagulo();
            //areaY = y.AreaTrinagulo();

            //Console.WriteLine("Área de x = {0}", areaX.ToString("F4", CultureInfo.InvariantCulture));
            //Console.WriteLine("Área de y = {0}", areaY.ToString("F4", CultureInfo.InvariantCulture));

            //if (areaX == areaY)
            //{
            //    Console.WriteLine("Áreas são iguais!");
            //}
            //else if (areaX > areaY)
            //{
            //    Console.WriteLine("Maior área: X");
            //}
            //else
            //{
            //    Console.WriteLine("Maior área: Y");
            //}
            #endregion

            #region 42. Começando a resolver um segundo problema exemplo
            //Produto p = new Produto();
            //Console.WriteLine("Entre os dados do Produto:");
            //Console.Write("Nome: ");
            //p.Nome = Console.ReadLine();
            //Console.Write("Preço: ");
            //p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Quantidade no estoque: ");
            //p.Quantidade = int.Parse(Console.ReadLine());

            //Console.WriteLine("Dados do produto: " + p);
            #endregion

            #region 43. Object e ToString
            //Produto p = new Produto();
            //Console.WriteLine("Entre os dados do Produto:");
            //Console.Write("Nome: ");
            //p.Nome = Console.ReadLine();
            //Console.Write("Preço: ");
            //p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Quantidade no estoque: ");
            //p.Quantidade = int.Parse(Console.ReadLine());

            //Console.WriteLine("Dados do produto: " + p);
            #endregion

            #region 44. Terminando de construir o programa
            //Produto p = new Produto();
            //Console.WriteLine("Entre os dados do Produto:");
            //Console.Write("Nome: ");
            //p.Nome = Console.ReadLine();
            //Console.Write("Preço: ");
            //p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Quantidade no estoque: ");
            //p.Quantidade = int.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("Dados do produto: " + p);

            //Console.WriteLine();
            //Console.Write("Digite o número de produtos a ser adicionado: ");
            //int qte = int.Parse(Console.ReadLine());
            //p.AdicionarProdutos(qte);
            //Console.WriteLine("Dados Atualizados!");

            //Console.WriteLine();
            //Console.WriteLine("Dados do produto: " + p);

            //Console.WriteLine();
            //Console.Write("Digite o número de produtos a ser removidos: ");
            //qte = int.Parse(Console.ReadLine());
            //p.RemoverProdutos(qte);
            //Console.WriteLine("Dados Atualizados!");

            //Console.WriteLine();
            //Console.WriteLine("Dados do produto: " + p);
            #endregion

            #region 45. Exercícios propostos (classes, atributos e métodos)
            #region Exercicio 1
            //Console.WriteLine("Informe os dados do Retangulo:");
            //Retangulo retangulo = new Retangulo();
            //Console.WriteLine("Entre a Largura e Altura do Retangulo:");
            //Console.Write("Largura: ");
            //retangulo.Largura = double.Parse(Console.ReadLine());
            //Console.Write("Altura: ");
            //retangulo.Altura = double.Parse(Console.ReadLine());

            //Console.WriteLine("AREA = {0}", retangulo.CalculaAreaRetangulo());
            //Console.WriteLine("PERÍMETRO = {0}", retangulo.CalculaPerimetroRetangulo());
            //Console.WriteLine("DIAGONAL = {0}", retangulo.CalculaDiagonalRetangulo());
            #endregion

            #region Exercicio 2
            //Console.WriteLine("Informe os dados do Funcionário:");
            //Funcionario funcionario = new Funcionario();
            //Console.Write("Nome: ");
            //funcionario.Nome = Console.ReadLine();
            //Console.Write("Salario Bruto: ");
            //funcionario.SalarioBruto = double.Parse(Console.ReadLine());
            //Console.Write("Imposto: ");
            //funcionario.Imposto = double.Parse(Console.ReadLine());

            //Console.WriteLine("Funcionário {0}", funcionario);

            //Console.WriteLine();
            //Console.Write("Digite uma porcentagem para aumentar: ");
            //funcionario.AumentarSalario(double.Parse(Console.ReadLine()));

            //Console.WriteLine();
            //Console.WriteLine("Dados atualizados: {0}", funcionario);
            #endregion

            #region Exercicio 3
            //Aluno aluno = new Aluno();
            //Console.WriteLine("Informe os dados do aluno:");
            //Console.Write("Nome do aluno: ");
            //aluno.Nome = Console.ReadLine();
            //Console.Write("Primeira do aluno: ");
            //aluno.Nota1 = double.Parse(Console.ReadLine());
            //Console.Write("Segunda do aluno: ");
            //aluno.Nota2 = double.Parse(Console.ReadLine());
            //Console.Write("Terceira do aluno: ");
            //aluno.Nota3 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Nota Final = {0}", aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            //aluno.VerificaAprovacao();
            #endregion
            #endregion

            #region 46. Membros estáticos - PARTE 1
            //Console.WriteLine("Informe os dados da circunferência:");
            //Console.Write("Entre o valor do raio: ");
            //double raio = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));

            //double circunferencia = Circunferencia(raio);
            //Console.WriteLine("Circunferência: {0}", circunferencia.ToString("F2", CultureInfo.InvariantCulture));

            //double volume = VolumeCircunferencia(raio);
            //Console.WriteLine("Volume da circunferência: {0}", volume.ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine("Valor de Pi: {0}", Pi.ToString("F2", CultureInfo.InvariantCulture));
            #endregion

            #region 47. Membros estáticos - PARTE 2
            //Console.WriteLine("Informe os dados da circunferência:");
            //Console.Write("Entre o valor do raio: ");
            //double raio = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));

            //double circunferencia = Calculadora.Circunferencia(raio);
            //Console.WriteLine("Circunferência: {0}", circunferencia.ToString("F2", CultureInfo.InvariantCulture));

            //double volume = Calculadora.VolumeCircunferencia(raio);
            //Console.WriteLine("Volume da circunferência: {0}", volume.ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine("Valor de Pi: {0}", Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
            #endregion

            #region 48. Exercícios propostos (membros estáticos)
            //Console.Write("Qual a cotação do dólar? ");
            //double valorDolar = double.Parse(Console.ReadLine());
            //Console.Write("Quantos Dólares você vai comprar? ");
            //double quantidadeDolares = double.Parse(Console.ReadLine());
            //Console.Write("Valor a ser pago em Reais = {0}", ConversorDeMoeda.ConverteDolarParaReal(valorDolar, quantidadeDolares).ToString("F2", CultureInfo.InvariantCulture));
            #endregion

            #region 51. Construtores

            //Console.WriteLine("Entre os dados do Produto:");
            //Console.Write("Nome: ");
            //string nome = Console.ReadLine();
            //Console.Write("Preço: ");
            //double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Quantidade no estoque: ");
            //int quantidade = int.Parse(Console.ReadLine());

            //Produto p = new Produto(nome, preco, quantidade);


            //Console.WriteLine();
            //Console.WriteLine("Dados do produto: " + p);

            //Console.WriteLine();
            //Console.Write("Digite o número de produtos a ser adicionado: ");
            //int qte = int.Parse(Console.ReadLine());
            //p.AdicionarProdutos(qte);
            //Console.WriteLine("Dados Atualizados!");

            //Console.WriteLine();
            //Console.WriteLine("Dados do produto: " + p);

            //Console.WriteLine();
            //Console.Write("Digite o número de produtos a ser removidos: ");
            //qte = int.Parse(Console.ReadLine());
            //p.RemoverProdutos(qte);
            //Console.WriteLine("Dados Atualizados!");

            //Console.WriteLine();
            //Console.WriteLine("Dados do produto: " + p);

            //Console.WriteLine();
            #endregion

            #region 52. Sobrecarga
            //Console.WriteLine("Entre os dados do Produto:");
            //Console.Write("Nome: ");
            //string nome = Console.ReadLine();
            //Console.Write("Preço: ");
            //double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Produto p = new Produto(nome, preco);
            //Console.WriteLine("Dados do produto: " + p);
            #endregion

            #region 53. Sintaxe alternativa para inicializar valores
            //Produto p = new Produto { 
            //    Nome = "TV", 
            //    Preco = 900, 
            //    Quantidade = 20 };
            //Console.WriteLine(p);
            #endregion

            #region 54. Palavra this
            //Produto p = new Produto
            //{
            //    Nome = "TV",
            //    Preco = 900,
            //    Quantidade = 20,
            //    testeThisNoConstrutor = 0
            //};
            //Console.WriteLine(p);
            #endregion

            #region 55. Encapsulamento
            //ProdutoEncapsulamento p = new ProdutoEncapsulamento("TV", 500, 10);

            //Console.WriteLine(p.GetNome());

            //p.SetNome("TV 4K");

            //Console.WriteLine(p.GetNome());

            //p.SetNome("T");

            //Console.WriteLine(p.GetNome());

            //Console.WriteLine(p.GetPreco());
            //Console.WriteLine(p.GetQuantidade());
            #endregion

            #region 56. Properties   
            //ProdutoEncapsulamento p = new ProdutoEncapsulamento("TV", 500, 10);

            //Console.WriteLine(p.Nome);

            //p.Nome ="TV 4K";

            //Console.WriteLine(p.Nome);

            //p.Nome = "T";

            //Console.WriteLine(p.Nome);

            //Console.WriteLine(p.Preco);
            //Console.WriteLine(p.Quantidade);

            #endregion

            #region 57. Auto Properties
            //ProdutoEncapsulamento p = new ProdutoEncapsulamento("TV", 500, 10);

            //Console.WriteLine(p.Nome);
            //Console.WriteLine(p.Preco);
            //Console.WriteLine(p.Quantidade);
            #endregion

            #region 58. Ordem sugerida para implementação de membros de classe
            //classe gerada para modelo e organização das novas classes
            //OrdemImplementacaoClasse
            #endregion

            #region 59. Modificadores de acesso
            //public
            //protected internal
            //internal
            //protected
            //private protected
            //private
            #endregion

            #region 60. Exercício de fixação
            //Console.Write("Entre o Número da conta: ");
            //int numeroConta = int.Parse(Console.ReadLine());
            //Console.Write("Entre o Nome do titular da conta: ");
            //string nomeTitular = Console.ReadLine();
            //Console.Write("Haverá deposito inicial (S/N)? ");
            //char opcao = char.Parse(Console.ReadLine());
            //ContaBancaria contaBancaria;
            //if (opcao == 'S' || opcao == 's')
            //{
            //    Console.Write("Entre o valor de depósito inicial: ");
            //    double saldo = double.Parse(Console.ReadLine());
            //    contaBancaria = new ContaBancaria(numeroConta, nomeTitular, saldo);
            //}
            //else
            //{
            //    contaBancaria = new ContaBancaria(numeroConta, nomeTitular);
            //}
            //Console.WriteLine();
            //Console.WriteLine(contaBancaria);

            //Console.WriteLine();
            //Console.Write("Entre com um valor para depósito: ");
            //contaBancaria.Deposito(double.Parse(Console.ReadLine()));
            //Console.WriteLine("Dados da conta atualizados:");
            //Console.WriteLine(contaBancaria);

            //Console.WriteLine();
            //Console.Write("Entre com um valor para saque: ");
            //contaBancaria.Saque(double.Parse(Console.ReadLine()));
            //Console.WriteLine("Dados da conta atualizados:");
            //Console.WriteLine(contaBancaria);
            #endregion

            #region 66. Tipos referência e tipos valor
            //Point p;
            //p.X = 10;
            //p.Y = 20;

            //Console.WriteLine(p);
            //p = new Point();
            //Console.WriteLine(p);
            #endregion

            #region 68. Nullable
            //Nullable<double> x = null;
            //double? y = 10.0;

            //Console.WriteLine(x.GetValueOrDefault());
            //Console.WriteLine(y.GetValueOrDefault());

            //Console.WriteLine(x.HasValue);
            //Console.WriteLine(y.HasValue);

            //if (x.HasValue)
            //{
            //    Console.WriteLine(x.Value);
            //}
            //else
            //{
            //    Console.WriteLine("X is null");
            //}

            //if (y.HasValue)
            //{
            //    Console.WriteLine(y.Value);
            //}
            //else
            //{
            //    Console.WriteLine("Y is null");
            //}

            //#region Operador de coalescência "??"
            //double a = x ?? 5;
            //double b = y ?? 5;

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //#endregion
            #endregion

            #region 69. Vetores - PARTE 1
            //int n = int.Parse(Console.ReadLine());

            //CalcularMediaDoubleArray(n);

            #endregion

            #region 70. Vetores - PARTE 2
            //int n = int.Parse(Console.ReadLine());

            //Product[] products = new Product[n];

            //for (int i = 0; i < n; i++)
            //{
            //    string name = Console.ReadLine();
            //    double price = double.Parse(Console.ReadLine());
            //    products[i] = new Product(name, price);
            //}

            //double sum = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    sum += products[i].Price;
            //}

            //double avg = sum / n;

            //Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));
            #endregion

            #region 71. Exercício de fixação (vetores)

            //Console.Write("How many rooms will be rented? ");
            //int quantidadelocacao = int.Parse(Console.ReadLine());

            //int quantidadeQuartos = 10;
            //Quarto[] vect = new Quarto[quantidadeQuartos];

            //for (int i = 0; i < quantidadelocacao; i++)
            //{
            //    Console.WriteLine("Rent #{0}", i + 1);
            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();
            //    Console.Write("Email: ");
            //    string email = Console.ReadLine();
            //    Console.Write("Room: ");
            //    int room = int.Parse(Console.ReadLine());

            //    for (int j = 0; j < quantidadeQuartos; j++)
            //        if (j == (room - 1))
            //        {
            //            vect[j] = new Quarto(name, email, room);
            //        }
            //    Console.WriteLine();

            //}
            //Console.WriteLine("All rooms");
            //for (int i = 0; i < quantidadeQuartos; i++)
            //{
            //    if (vect[i] != null)
            //    {
            //        Console.WriteLine(vect[i].ToString());
            //    }
            //    else
            //    {
            //        Console.WriteLine(i+1 + ": Quarto Disponivel");
            //    }

            //}

            //Console.WriteLine();
            //Console.WriteLine("Busy rooms");
            //for (int i = 0; i < quantidadeQuartos; i++)
            //{
            //    if (vect[i] != null)
            //    {
            //        Console.WriteLine(vect[i].ToString());
            //    }
            //}
            #endregion

            #region 72. Modificador de parâmetros params
            //#region Sobrecarga de metodos
            //Console.WriteLine("Sobrecarga de metodos");
            //int s1 = Calculator.Sum(2, 3);
            //int s2 = Calculator.Sum(2, 3, 4);

            //Console.WriteLine(s1);
            //Console.WriteLine(s2);
            //#endregion

            //#region vetor
            //Console.WriteLine("Vetor");
            //int v1 = Calculator.SumVect(new int[] { 2, 3 });
            //int v2 = Calculator.SumVect(new int[] { 2, 3, 4 });

            //Console.WriteLine(v1);
            //Console.WriteLine(v2);
            //#endregion

            //#region Vetor + Params 
            //Console.WriteLine("Vetor + Params");
            //int vp1 = Calculator.SumVectParams( 2, 3 );
            //int vp2 = Calculator.SumVectParams( 2, 3, 4 );

            //Console.WriteLine(vp1);
            //Console.WriteLine(vp2);
            //#endregion
            #endregion

            #region 73. Modificadores de parâmetros ref e out
            //#region Ref
            //int a = 10;
            //Calculator.Triple(ref a);
            //Console.WriteLine(a);
            //#endregion

            //#region Out
            //int b = 10;
            //int triple;
            //Calculator.Triple(b, out triple);
            //Console.WriteLine(triple);
            //#endregion

            #endregion

            #region 74. Boxing e unboxing
            //int x = 20;
            //int y;
            //#region Boxing
            //Object obj = x;
            //#endregion

            //#region Unboxing
            //y = (int)obj;
            //#endregion
            #endregion

            #region 75. Sintaxe opcional: laço foreach

            //string[] vect = new string[] { "Maria", "Alex", "Bob" };

            //Console.WriteLine("####For####");
            //for (int i = 0; i < vect.Length; i++)
            //{
            //    Console.WriteLine(vect[i]);
            //}

            //Console.WriteLine("##Foreach##");
            //foreach (var item in vect)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 76. Listas (List) - PARTE 1
            //List<string> list = new List<string>();

            //List<string> list2 = new List<string> { "Maria", "Alex" };

            #endregion

            #region 77. Listas (List) - PARTE 2
            //List<string> list = new List<string>();

            //list.Add("Maria");
            //list.Add("Alex");
            //list.Add("Bob");
            //list.Add("Anna");

            //list.Insert(2, "Marco");


            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("List Count: {0}", list.Count);

            //string s1 = list.Find(x => x[0] == 'A');
            //Console.WriteLine("First 'A': {0}", s1);

            //string s2 = list.FindLast(x => x[0] == 'A');
            //Console.WriteLine("Last 'A': {0}", s2);

            //int pos1 = list.FindIndex(x => x[0] == 'A');
            //Console.WriteLine("First position 'A': {0}", pos1);

            //int pos2 = list.FindLastIndex(x => x[0] == 'A');
            //Console.WriteLine("Last position 'A': {0}", pos2);

            //Console.WriteLine("Lista com nomes da primeira lista com 5 caracteres");
            //List<string> list2 = list.FindAll(x => x.Length == 5);
            //foreach (var item in list2)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("Removendo Alex da lista");
            //list.Remove("Alex");
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("Removendo todos da lista que começam com 'M'");
            //list.RemoveAll(x => x[0] == 'M');
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("Removendo pela posição");
            //list.RemoveAt(0);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //list.Add("Maria");
            //list.Add("Alex");
            //list.Add("Bob");
            //list.Add("Marco");
            //Console.WriteLine("Removendo um Range");
            //list.RemoveRange(2, 2);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 78. Exercício de fixação (listas)
            //Console.Write("How many employees will be resgistered? ");
            //int quantityEmployees = int.Parse(Console.ReadLine());
            //List<Employee> employees = new List<Employee>();
            //for (int i = 0; i < quantityEmployees; i++)
            //{
            //    Console.WriteLine("Employee #{0}", i+1);
            //    Console.Write("Id: ");
            //    int id = int.Parse(Console.ReadLine());
            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();
            //    Console.Write("Salary: ");
            //    double salary = double.Parse(Console.ReadLine());

            //    employees.Add( new Employee(id, name, salary));
            //    Console.WriteLine();
            //}

            //Console.Write("Enter the employee id that will have salary increase: ");
            //int idConsulta = int.Parse(Console.ReadLine());

            //bool FindId = false;
            //foreach (var item in employees)
            //{    
            //    if (item.Id == idConsulta)
            //    {
            //        Console.Write("Enter the percentage: ");
            //        double percentage = double.Parse(Console.ReadLine());
            //        item.SalaryIncrease(percentage);
            //        FindId = true;
            //    }      
            //}
            //if (FindId == false)
            //{
            //    Console.WriteLine("Employee not find");
            //}

            //foreach (var item in employees)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 79. Matrizes
            //double[,] mat = new double[2, 3];

            //Console.WriteLine(mat.Length); //quantidade de elementos da Matriz

            //Console.WriteLine(mat.Rank); //quantidade linhas

            //Console.WriteLine(mat.GetLength(0)); //1º dimensão = linhas

            //Console.WriteLine(mat.GetLength(1)); //2º dimensão =Colunas

            #endregion

            #region 80. Exercício resolvido (matrizes)
            //Console.Write("Informe o tamanho da Matriz: ");
            //int n = int.Parse(Console.ReadLine());
            //int[,] mat = new int[n, n];

            //List<int> diagonal = new List<int>();
            //List<int> negativos = new List<int>();

            //for (int i = 0; i < n; i++)
            //{
            //    string[] values = Console.ReadLine().Split(' ');

            //    for (int j = 0; j < n; j++)
            //    {   
            //        mat[i, j] = int.Parse(values[j]);
            //    }
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //        {
            //            diagonal.Add(mat[i, j]);
            //        }

            //        if (mat[i, j] < 0)
            //        {
            //            negativos.Add(mat[i, j]);
            //        }
            //    }
            //}

            //Console.WriteLine("Main diagonal");
            //foreach (var item in diagonal)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Negatives number: " + negativos.Count);
            //Console.Write("Are: ");
            //foreach (var item in negativos)
            //{
            //    Console.Write( item + " ");
            //}
            //Console.WriteLine();
            #endregion

            #region 81. Exercício de fixação (matrizes)
            //Console.Write("Informe o numero de linhas da Matriz: ");
            //int m = int.Parse(Console.ReadLine());
            //Console.Write("Informe o numero de Colunas da Matriz: ");
            //int n = int.Parse(Console.ReadLine());

            //int[,] mat = new int[m, n];

            //for (int i = 0; i < m; i++)
            //{
            //    string[] values = Console.ReadLine().Split(' ');
            //    for (int j = 0; j < n; j++)
            //    {
            //        //mat[i, j] = int.Parse(Console.ReadLine());
            //        mat[i, j] = int.Parse(values[j]);
            //    }
            //}

            //for (int i = 0; i < m; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write(mat[i, j] + " "); 
            //    }
            //    Console.WriteLine();
            //}

            //Console.Write("Informe um valor para ser encontrado na Matriz: ");
            //int x = int.Parse(Console.ReadLine());

            //for (int i = 0; i < m; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (mat[i, j] == x)
            //        {
            //            Console.WriteLine("{0} encontrado! na posição [{1},{2}]",x, i, j);

            //            if(i > 0)
            //            {
            //                Console.WriteLine("numero acima de {0} é: {1}", x, mat[i-1, j]);
            //            }

            //            if(j > 0)
            //            {
            //                Console.WriteLine("numero a esquerda de {0} é: {1}", x, mat[i, j -1]);
            //            }

            //            if (j < m)
            //            {
            //                Console.WriteLine("numero a Direita de {0} é: {1}", x, mat[i, j + 1]);
            //            }

            //            if (i < n)
            //            {
            //                Console.WriteLine("numero abaixo de {0} é: {1}", x, mat[i + 1, j]);
            //            }
            //        }   
            //    }
            //}

            #endregion

            #region 85. Inferência de tipos: palavra var
            //var x = 10;
            //var y = 20.0;
            //var z = "Marcia";

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

            ////sempre que possivel definit o tipo da variavel como int, double string etc evitando falhas no condigo com o var
            #endregion

            #region 86. Sintaxe alternativa - switch-case
            //Console.Write("Digite o dia da semana(1~7):  ");
            //int dayNumber = int.Parse(Console.ReadLine());
            //String dayName = null;

            //#region Usando IF
            //if (dayNumber == 1)
            //{
            //    dayName = "Sunday";
            //}
            //else if (dayNumber == 2)
            //{
            //    dayName = "Monday";
            //}
            //else if (dayNumber == 3)
            //{
            //    dayName = "Tuesday";
            //}
            //else if (dayNumber == 4)
            //{
            //    dayName = "Wednesday";
            //}
            //else if (dayNumber == 5)
            //{
            //    dayName = "Thursday";
            //}
            //else if (dayNumber == 6)
            //{
            //    dayName = "Friday";
            //}
            //else if (dayNumber == 7)
            //{
            //    dayName = "Saturday";
            //}
            //else
            //{
            //    Console.WriteLine("Invalid value");
            //}
            //// bool b1 String.IsNullOrEmpty(dayName);
            //if (dayName != null)
            //{
            //    Console.WriteLine("Day: {0}", dayName);
            //}

            //#endregion

            //#region Usando SWITCH-CASE

            //if (dayName != null)
            //{
            //    switch (dayNumber)
            //    {
            //        case 1:
            //            dayName = "Sunday";
            //            break;
            //        case 2:
            //            dayName = "Monday";
            //            break;
            //        case 3:
            //            dayName = "Tuesday";
            //            break;
            //        case 4:
            //            dayName = "Wednesday";
            //            break;
            //        case 5:
            //            dayName = "Thyrsday";
            //            break;
            //        case 6:
            //            dayName = "Friday";
            //            break;
            //        case 7:
            //            dayName = "Saturday";
            //            break;

            //        default:
            //            Console.WriteLine("Value Invalid");
            //            break;
            //    }
            //    Console.WriteLine("Day: {0}", dayName);
            //}
            //#endregion

            #endregion

            #region 87. Sintaxe alternativa - expressão condicional ternária
            //double preco = double.Parse(Console.ReadLine());
            //double desconto;

            //#region Usando IF
            //if (preco < 20.00)
            //{
            //    desconto = preco * 0.1;
            //}
            //else
            //{
            //    desconto = preco * 0.05;
            //}
            //Console.WriteLine(desconto);
            //#endregion

            //#region Ternaria
            //double descontoTernario = (preco < 20.0) ? preco * 0.1 : preco * 0.5;
            //Console.WriteLine(desconto);
            //#endregion

            #endregion

            #region 88. Funções interessantes para string
            //string original = "abcde FGHIJ ABC abc DEFG     ";

            ////string s1 = original.ToUpper();
            ////string s2 = original.ToLower();
            ////string s3 = original.Trim();
            ////int n1 = original.IndexOF("bc");
            ////int n2 = original.LastIndexOF("bc");
            ////string s4 = original.Substring(3);
            ////string s5 = original.Substring(3, 5);
            ////string s6 = original.Replace('a', 'x');
            ////string s7 = original.Replace('abc', 'xy');
            ////bool b1 = String.IsNullOrEmpty(original);
            ////bool b2 = String.IsNullOrWhiteSpace(original);
            //Console.WriteLine("original             : -{0}-", original);
            //Console.WriteLine("ToUpper              : -{0}-", original.ToUpper());
            //Console.WriteLine("ToLower              : -{0}-", original.ToLower());
            //Console.WriteLine("ToTrim               : -{0}-", original.Trim());
            //Console.WriteLine("IndexOf('bc')        : -{0}-", original.IndexOf("bc"));
            //Console.WriteLine("LastIndexOf('bc')    : -{0}-", original.LastIndexOf("bc"));
            //Console.WriteLine("Substring(3)         : -{0}-", original.Substring(3));
            //Console.WriteLine("Substring(3, 5)      : -{0}-", original.Substring(3, 5));
            //Console.WriteLine("Replace('a', 'x')    : -{0}-", original.Replace('a', 'x'));
            //Console.WriteLine("Replace('abc', 'xy') : -{0}-", original.Replace("abc", "xy"));
            //Console.WriteLine("IsNullOrEmpty        : -{0}-", String.IsNullOrEmpty(original));
            //Console.WriteLine("IsNullOrWhiteSpace   : -{0}-", String.IsNullOrWhiteSpace(original));

            #endregion

            #region 89. DateTime - representando data e hora
            //DateTime d1 = DateTime.Now;

            //Console.WriteLine(d1);
            //Console.WriteLine(d1.Ticks);

            //DateTime d2 = new DateTime(2018, 11, 25);
            //Console.WriteLine(d2);
            //d2 = new DateTime(2018, 11, 25, 20, 45, 3);
            //Console.WriteLine(d2);
            //d2 = new DateTime(2018, 11, 25, 20, 45, 3, 500);
            //Console.WriteLine(d2);

            //d2 = DateTime.Now;
            //Console.WriteLine(d2);

            //d2 = DateTime.Today;
            //Console.WriteLine(d2);

            //d2 = DateTime.UtcNow;
            //Console.WriteLine(d2);

            //d2 = DateTime.Parse("2000-08-15");
            //Console.WriteLine(d2);
            //d2 = DateTime.Parse("2000-08-15 13:05:58");
            //Console.WriteLine(d2);
            //d2 = DateTime.Parse("15/08/2000");
            //Console.WriteLine(d2);
            //d2 = DateTime.Parse("15/08/2000 13:05:58");
            //Console.WriteLine(d2);

            //d2 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            //Console.WriteLine(d2);

            //d2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            //Console.WriteLine(d2);

            #endregion

            #region 90. TimeSpan - representando durações
            //TimeSpan t1 = new TimeSpan(0, 1, 30);
            //Console.WriteLine(t1);

            //Console.WriteLine(t1.Ticks);

            //t1 = new TimeSpan();
            //Console.WriteLine(t1);

            //t1 = new TimeSpan(900000000L);
            //Console.WriteLine(t1);

            //t1 = new TimeSpan(2, 11, 21);
            //Console.WriteLine(t1);

            //t1 = new TimeSpan(1, 2, 11, 21);
            //Console.WriteLine(t1);

            //t1 = new TimeSpan(1, 2, 11, 21, 321);
            //Console.WriteLine(t1);

            //t1 = TimeSpan.FromDays(1.5);
            //Console.WriteLine(t1);

            //t1 = TimeSpan.FromHours(1.5);
            //Console.WriteLine(t1);

            //t1 = TimeSpan.FromMinutes(1.5);
            //Console.WriteLine(t1);

            //t1 = TimeSpan.FromSeconds(1.5);
            //Console.WriteLine(t1);

            //t1 = TimeSpan.FromMilliseconds(1.5);
            //Console.WriteLine(t1);

            #endregion

            #region 91. Propriedades e operações com DateTime
            //DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            //Console.WriteLine(d);

            //Console.WriteLine("1) Date: {0}", d.Date);
            //Console.WriteLine("2) Day: {0}", d.Day);
            //Console.WriteLine("3) DayOfWeek: {0}", d.DayOfWeek);
            //Console.WriteLine("4) DayOfYear: {0}", d.DayOfYear);
            //Console.WriteLine("5) Hour: {0}", d.Hour);
            //Console.WriteLine("6) Kind: {0}", d.Kind);
            //Console.WriteLine("7) Millisecond: {0}", d.Millisecond);
            //Console.WriteLine("8) Minute: {0}", d.Minute);
            //Console.WriteLine("9) Month: {0}", d.Month);
            //Console.WriteLine("10) Second: {0}", d.Second);
            //Console.WriteLine("11) Ticks: {0}", d.Ticks);
            //Console.WriteLine("12) TimeOfDay: {0}", d.TimeOfDay);
            //Console.WriteLine("13) Year: {0}", d.Year);

            //#region Formatação
            //Console.WriteLine(d.ToLongDateString());
            //Console.WriteLine(d.ToShortDateString());
            //Console.WriteLine(d.ToLongTimeString());
            //Console.WriteLine(d.ToShortTimeString());
            //Console.WriteLine(d.ToString());

            //Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss"));
            //Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss.fff"));
            //#endregion

            //#region Operações com data
            //DateTime d2;
            //Console.WriteLine(d2 = d.AddHours(2));
            //Console.WriteLine(d2 = d.AddMinutes(3));

            //Console.WriteLine(d2 = DateTime.Now);
            //Console.WriteLine(d2 = d2.AddDays(7));

            //TimeSpan t = d2.Subtract(d);
            //Console.WriteLine(t);
            //#endregion

            #endregion

            #region 92. Propriedades e operações com TimeSpan
            //TimeSpan t1;
            //Console.WriteLine(t1 = TimeSpan.MaxValue);
            //Console.WriteLine(t1 = TimeSpan.MinValue);
            //Console.WriteLine(t1 = TimeSpan.Zero);

            //Console.WriteLine(t1 = new TimeSpan(2, 3, 5, 7, 11));

            //Console.WriteLine(" Days: {0}", t1.Days);
            //Console.WriteLine(" Hours: {0}", t1.Hours);
            //Console.WriteLine(" Minutes: {0}", t1.Minutes);
            //Console.WriteLine(" Milliseconds: {0}", t1.Milliseconds);
            //Console.WriteLine(" Seconds: {0}", t1.Seconds);
            //Console.WriteLine(" Ticks: {0}", t1.Ticks);

            //Console.WriteLine(" TotalDays: {0}", t1.TotalDays);
            //Console.WriteLine(" TotalHours: {0}", t1.TotalHours);
            //Console.WriteLine(" TotalMinutes: {0}", t1.TotalMinutes);
            //Console.WriteLine(" TotalSeconds: {0}", t1.TotalSeconds);
            //Console.WriteLine(" TotalMilliseconds: {0}", t1.TotalMilliseconds);

            //#region Opreções com TimeSpam
            //TimeSpan t2 = new TimeSpan(1, 30, 10);
            //TimeSpan t3 = new TimeSpan(0, 10, 5);

            //TimeSpan sum = t2.Add(t3);
            //Console.WriteLine(sum);

            //TimeSpan dif = t2.Subtract(t3);
            //Console.WriteLine(dif);

            //TimeSpan mult = t3.Multiply(2.0);
            //Console.WriteLine(mult);

            //TimeSpan div = t3.Divide(2.0);
            //Console.WriteLine(div);

            //#endregion

            #endregion

            #region 93. DateTimeKind e padrão ISO 8601
            //DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);

            //DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);

            //DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            //Console.WriteLine(d1);
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);

            //Console.WriteLine();
            //Console.WriteLine("d1: {0}", d1);
            //Console.WriteLine("d1 Kind: {0}", d1.Kind);
            //Console.WriteLine("d1 to Local: {0}", d1.ToLocalTime());
            //Console.WriteLine("d1 to UTC: {0}", d1.ToUniversalTime());

            //Console.WriteLine();
            //Console.WriteLine("d2: {0}", d2);
            //Console.WriteLine("d2 Kind: {0}", d2.Kind);
            //Console.WriteLine("d2 to Local: {0}", d2.ToLocalTime());
            //Console.WriteLine("d2 to UTC: {0}", d2.ToUniversalTime());

            //Console.WriteLine();
            //Console.WriteLine("d3: {0}", d3);
            //Console.WriteLine("d3 Kind: {0}", d3.Kind);
            //Console.WriteLine("d3 to Local: {0}", d3.ToLocalTime());
            //Console.WriteLine("d3 to UTC: {0}", d3.ToUniversalTime());

            //Console.WriteLine();
            //DateTime d4 = DateTime.Parse("2000-08-15 13:05:58");
            //DateTime d5 = DateTime.Parse("2000-08-15T13:05:58Z");
            //Console.WriteLine(d4);
            //Console.WriteLine(d5);

            //Console.WriteLine();
            //Console.WriteLine("d4: {0}", d4);
            //Console.WriteLine("d4 Kind: {0}", d4.Kind);
            //Console.WriteLine("d4 to Local: {0}", d4.ToLocalTime());
            //Console.WriteLine("d4 to UTC: {0}", d4.ToUniversalTime());

            //Console.WriteLine();
            //Console.WriteLine("d5: {0}", d5);
            //Console.WriteLine("d5 Kind: {0}", d5.Kind);
            //Console.WriteLine("d5 to Local: {0}", d5.ToLocalTime());
            //Console.WriteLine("d5 to UTC: {0}", d5.ToUniversalTime());

            //Console.WriteLine(d4.ToString("yyyy-MM-ddTHH:mm:ssZ")); // Errado não fazer assim
            //Console.WriteLine(d4.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ")); // correto
            #endregion

            #region 115. Enumerações
            ////OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            ////OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");
            ////OrderStatus os;
            ////Enum.TryParse("Delivered", out os);

            //Order order = new Order { Id = 1000, Moment = DateTime.Now, Status = OrderStatus.PendingPayment };
            //Console.WriteLine(order);

            //string txt = OrderStatus.PendingPayment.ToString();
            //Console.WriteLine(txt);

            //OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            //Console.WriteLine(os);

            #endregion

            #region 120. Exercício resolvido 01 - PARTE 2/3
            //OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            //OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");
            //OrderStatus os;
            //Enum.TryParse("Delivered", out os);

            #endregion

            #region 121. Exercício resolvido 01 - PARTE 3/3
            //Console.Write("Enter department's name: ");
            //Department department = new Department(Console.ReadLine());

            //Console.WriteLine("Enter worker data: ");

            //Console.Write("Name: ");
            //string name = Console.ReadLine();

            //Console.Write("Level (Junior/MidLevel/Senior): ");
            //WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            //Console.Write("Base Salary: ");
            //double baseSalary = double.Parse(Console.ReadLine());

            //Worker worker = new Worker(name, level, baseSalary, department);

            //Console.WriteLine();
            //Console.Write("How many contracts to this worker: ");
            //int contract = int.Parse(Console.ReadLine());

            //Console.WriteLine();
            //for (int i = 0; i < contract; i++)
            //{
            //    Console.WriteLine("Enter #{0} contract data: ", i+1);
            //    Console.Write("Date (DD/MM/YYYY): ");
            //    DateTime date = DateTime.Parse(Console.ReadLine());

            //    Console.Write("Value per hour: ");
            //    double valueHour = double.Parse(Console.ReadLine());

            //    Console.Write("Duration (hours): ");
            //    int hours = int.Parse(Console.ReadLine());
            //    HourContract contr = new HourContract(date, valueHour, hours);
            //    worker.AddContract(contr);
            //    Console.WriteLine();
            //}

            ////foreach (var item in worker.Contracts)
            ////{
            ////    Console.WriteLine(item.TotalValue());
            ////}

            //Console.Write("Enter month and year to calculate income (MM/YYYY): ");

            //#region Feito por mim usando split
            //string monthAndYear = Console.ReadLine();
            //string[] monthYear = monthAndYear.Split('/');
            //int month = int.Parse(monthYear[0]);
            //int year = int.Parse(monthYear[1]);
            //#endregion

            //#region Feito pelo professor usando substring
            ////string monthAndYear = Console.ReadLine();
            ////int month = int.Parse(monthAndYear.Substring(0, 2));
            ////int year = int.Parse(monthAndYear.Substring(3));
            //#endregion

            //Console.WriteLine();
            //Console.WriteLine("Name: {0}", worker.Name);
            //Console.WriteLine("Departament: {0}", worker.Department.Name);
            //Console.WriteLine("Income for: {0}: {1}", monthAndYear, worker.Income(year, month));

            #endregion

            #region 122. Exercício resolvido 2 (demo StringBuilder)
            //Comment c1 = new Comment("Have a nice trip");
            //Comment c2 = new Comment("Wow that's awesome!");

            //Post p1 = new Post(DateTime.Now, "Traveling to new zealand", "I'm going to visit this wonderful country!", 12);
            //p1.AddComment(c1);
            //p1.AddComment(c2);
            //Console.WriteLine(p1);

            //Comment c3 = new Comment("Good night");
            //Comment c4 = new Comment("May the force be with you");

            //Post p2 = new Post(DateTime.Now, "Good night guys", "see you tomorrow", 5);
            //p2.AddComment(c3);
            //p2.AddComment(c4);

            //Console.WriteLine(p2);

            //Post p3 = new Post(DateTime.Now, "My wife is gorgeous", "I love her", 500000);

            //Console.WriteLine(p3);

            #endregion

            #region 123. Exercício proposto (Enumerações e Composição)
            //Console.WriteLine("Enter cliente data:");
            //Console.Write("Name: ");
            //string nameClient = Console.ReadLine();
            //Console.Write("Email: ");
            //string emailClient = Console.ReadLine();
            //Console.Write("Birth date (DD/MM/YYYY): ");
            //DateTime birthDateClient = DateTime.Parse(Console.ReadLine());

            //ClientAula123 client1 = new ClientAula123(nameClient, emailClient, birthDateClient);

            //Console.WriteLine("Enter order data:");
            //Console.Write("Status: ");
            //OrderStatus statusOrder = Enum.Parse<OrderStatus>(Console.ReadLine());

            //Console.Write("How many items to this order? ");
            //int quantityOrder = int.Parse(Console.ReadLine());

            //OrderAula123 orderAula123 = new OrderAula123(DateTime.Now, statusOrder, client1);
            //ProductAula123 product;
            //OrderItemAula123 itemAula123;
            //for (int i = 0; i < quantityOrder; i++)
            //{
            //    Console.WriteLine("Enter #{0} item data: ", i +1);
            //    Console.Write("Product name: ");
            //    string productName = Console.ReadLine();
            //    Console.Write("Product price: ");
            //    double productPrice = double.Parse(Console.ReadLine());
            //    Console.Write("Quantity: ");
            //    int quantityProduct = int.Parse(Console.ReadLine());

            //    product = new ProductAula123(productName, productPrice);

            //    itemAula123 = new OrderItemAula123(quantityProduct, productPrice, product);

            //    orderAula123.AddItem(itemAula123);
            //}

            //Console.WriteLine(orderAula123.ToString()); 
            #endregion

            #region 126. Herança
            //BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100, 500);

            //Console.WriteLine(account.Balance);

            ////quando está como protected só é possivel alterar na propria classe ou herdeiras
            ////account.Balance = 200;
            #endregion

            #region 127. Upcasting e downcasting
            //Account acc = new Account(1001, "Alex", 0);
            //BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0, 500);

            ////UPCASTING
            //Account acc1 = bacc;
            //Account acc2 = new BusinessAccount(1003, "Bob", 0, 200);
            //Account acc3 = new SavingsAccount(1004, "Anna", 0, 0.01);

            ////DOWNCASTING
            //BusinessAccount acc4 = (BusinessAccount)acc2;
            //Console.WriteLine(acc4.Balance);
            //acc4.Loan(100);
            //Console.WriteLine(acc4.Balance);

            ////gera erro em tempo de execução devido serem de classes diferentes
            ////BusinessAccount acc5 = (BusinessAccount)acc3;

            //if (acc3 is BusinessAccount)
            //{
            //    //BusinessAccount acc5 = (BusinessAccount)acc3;
            //    BusinessAccount acc5 = acc3 as BusinessAccount;
            //    Console.WriteLine(acc5.Balance);
            //    acc5.Loan(100);
            //    Console.WriteLine(acc5.Balance);
            //    Console.WriteLine("Loan!");
            //}else if(acc3 is SavingsAccount)
            //{
            //    //SavingsAccount acc5 = (SavingsAccount)acc3;
            //    SavingsAccount acc5 = acc3 as SavingsAccount;
            //    Console.WriteLine(acc5.Balance);
            //    acc5.UpDateBalance();
            //    Console.WriteLine(acc5.Balance);
            //    Console.WriteLine("UpDate!");    
            //}
            #endregion

            #region 128. Sobreposição, palavras virtual, override e base
            //Account acc1 = new Account(1001, "Alex", 500);
            //Account acc2 = new SavingsAccount(1002, "Anna", 500, 0.01);
            //Account acc3 = new BusinessAccount(1003, "Bob", 500, 100);

            //acc1.Withdraw(10);
            //acc2.Withdraw(10);
            //acc3.Withdraw(10);

            //Console.WriteLine("Account: {0}",acc1.Balance);
            //Console.WriteLine("SavingAccount: {0}", acc2.Balance);
            //Console.WriteLine("BusinessAccount: {0}", acc3.Balance);
            #endregion

            #region 129. Classes e métodos selados

            #endregion

            #region 131. Exercício resolvido - PARTE 1, 132. Exercício resolvido - PARTE 2
            //Console.Write("Enter the number of employees: ");
            //int quantityEmployee = int.Parse(Console.ReadLine());

            //EmployeeClass131 employee;
            //List<EmployeeClass131> listEmployeeClass131s = new List<EmployeeClass131>();
            //for (int i = 0; i < quantityEmployee; i++)
            //{
            //    Console.WriteLine("Employee #{0} data: ", i+1);
            //    Console.Write("Outsourced (y/n)? ");
            //    char boolOutsourced = char.Parse(Console.ReadLine());

            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();

            //    Console.Write("Hours: ");
            //    int hours = int.Parse(Console.ReadLine());

            //    Console.Write("Value per hour: ");
            //    double valuePerHour = double.Parse(Console.ReadLine());

            //    if (boolOutsourced == 'y' || boolOutsourced == 'Y')
            //    {
            //        Console.Write("Additional charge: ");
            //        double additionalCharge = double.Parse(Console.ReadLine());

            //        employee = new OutsourceEmployee(name, hours, valuePerHour, additionalCharge);
            //    }
            //    else
            //    {
            //        employee = new EmployeeClass131(name, hours, valuePerHour);
            //    }
            //    listEmployeeClass131s.Add(employee);
            //}

            ////versão do professor
            //Console.WriteLine();
            //Console.WriteLine("PAYMENTS: ");
            //foreach (var item in listEmployeeClass131s)
            //{
            //    Console.WriteLine("{0} - $ {1}", item.Name, item.Payment());
            //}
            ////minha versão
            //Console.WriteLine();
            //Console.WriteLine("PAYMENTS: ");
            //foreach (var item in listEmployeeClass131s)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            #endregion

            #region 133. Exercício proposto (herança e polimorfismo)
            //Console.Write("Enter the number of products: ");
            //int quantityProduct = int.Parse(Console.ReadLine());

            //ProductClass133 product;
            //List<ProductClass133> listProducts = new List<ProductClass133>();
            //for (int i = 0; i < quantityProduct; i++)
            //{
            //    Console.WriteLine("Product #{0} data: ", i +1);
            //    Console.Write("Common, used, or imported (c / u / i)? ");
            //    char typeProduct = char.Parse(Console.ReadLine());

            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();

            //    Console.Write("Price: ");
            //    double price = double.Parse(Console.ReadLine());

            //    if (typeProduct == 'u' || typeProduct == 'U')
            //    {
            //        Console.Write("Manufacture date: ");
            //        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
            //        product = new UsedProductClass133(name, price, manufactureDate);
            //    }
            //    else if (typeProduct == 'i' || typeProduct == 'I')
            //    {
            //        Console.Write("Customs fee: ");
            //        double customsFee = double.Parse(Console.ReadLine());
            //        product = new ImportdProductClass133(name, price, customsFee);
            //    }
            //    else
            //    {
            //        product = new ProductClass133(name, price);
            //    }
            //    listProducts.Add(product);
            //}

            //Console.WriteLine();
            //Console.WriteLine("PRICE TAGS:");
            //foreach (var item in listProducts)
            //{
            //    Console.WriteLine(item.PriceTag());
            //}
            #endregion

            #region 134. Classes abstratas
            //List<AccountClass134> listAccountClass134s = new List<AccountClass134>();

            //listAccountClass134s.Add(new SavingsAccountClass134(1001, "Alex", 500, 0.01));
            //listAccountClass134s.Add(new BusinessAccountClass134(1002, "Maria", 500, 400));
            //listAccountClass134s.Add(new SavingsAccountClass134(1003, "Bob", 500, 0.01));
            //listAccountClass134s.Add(new BusinessAccountClass134(1004, "Anna", 500, 400));

            //double sum = 0;
            //foreach (var item in listAccountClass134s)
            //{
            //    sum += item.Balance;
            //}

            //Console.WriteLine("Total balance: {0}", sum.ToString("F2", CultureInfo.InvariantCulture));

            //foreach (var item in listAccountClass134s)
            //{
            //    item.Withdraw(10);
            //}

            //foreach (var item in listAccountClass134s)
            //{
            //    Console.WriteLine("Updated balance for account {0}: {1}", item.Number, item.Balance.ToString("F2", CultureInfo.InvariantCulture));
            //}
            #endregion

            #region 135. Métodos abstratos 136. Exercício resolvido (métodos abstratos)
            //Console.Write("Enter the number of shapes: ");
            //int quantityShapes = int.Parse(Console.ReadLine());
            //Shape shape;
            //List<Shape> shapesList = new List<Shape>();

            //for (int i = 0; i < quantityShapes; i++)
            //{
            //    Console.WriteLine("Shape #{0} data:", i + 1);
            //    Console.Write("Rectangle or Circle (r/c)? ");
            //    char typeShape = char.Parse(Console.ReadLine());
            //    Console.Write("Color (Black/Blue/Red): ");
            //    Color color = Enum.Parse<Color>(Console.ReadLine());

            //    //jeito que eu fiz
            //    //string enterColor = Console.ReadLine();
            //    //jeito do professor
            //    //Color color = Color.Black;
            //    //if (enterColor == "Black")
            //    //{
            //    //    color = Color.Black;
            //    //}
            //    //else if (enterColor == "Blue")
            //    //{
            //    //    color = Color.Blue;
            //    //}
            //    //else if (enterColor == "Red")
            //    //{
            //    //    color = Color.Red;
            //    //}

            //    if (typeShape == 'r' || typeShape == 'R')
            //    {
            //        Console.Write("Width: ");
            //        double width = double.Parse(Console.ReadLine());
            //        Console.Write("Height: ");
            //        double height = double.Parse(Console.ReadLine());

            //        shape = new Rectangle(color, width, height);
            //    }
            //    else //if (typeShape == 'c' || typeShape == 'C')
            //    {
            //        Console.Write("Radius : ");
            //        double radius = double.Parse(Console.ReadLine());

            //        shape = new Circle(color, radius);
            //    }
            //    shapesList.Add(shape);
            //}

            //Console.WriteLine();
            //Console.WriteLine("SHAPE AREAS: ");
            //foreach (var item in shapesList)
            //{
            //    Console.WriteLine(item.Area().ToString("F2", CultureInfo.InvariantCulture)); 
            //}
            #endregion

            #region 137. Exercício proposto (métodos abstratos)
            //Console.Write("Enter the number of tax payers: ");
            //int quantityPayers = int.Parse(Console.ReadLine());

            ////Contributor contributor;
            //List<Contributor> contributors = new List<Contributor>();
            //for (int i = 1; i <= quantityPayers; i++)
            //{
            //    Console.WriteLine("Tax payer #{0} data:", i);
            //    Console.Write("Individual or company (i/c)? ");
            //    char typePayer = char.Parse(Console.ReadLine());

            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();

            //    Console.Write("Anual Income: ");
            //    double anualIncome = double.Parse(Console.ReadLine());

            //    if (typePayer == 'i' || typePayer == 'I')
            //    {
            //        Console.Write("Health expenditures: ");
            //        contributors.Add(new PhysicalPerson(name, anualIncome, double.Parse(Console.ReadLine())));
            //    }
            //    else
            //    {
            //        Console.Write("Number of employees: ");
            //        contributors.Add(new LegalPerson(name, anualIncome, int.Parse(Console.ReadLine())));
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("TAXES PAID: ");
            //double totalTax = 0;
            //foreach (var item in contributors)
            //{
            //    Console.WriteLine("{0}: $ {1}", item.Name, item.IncomeTax().ToString("F2", CultureInfo.InvariantCulture));
            //    totalTax += item.IncomeTax();
            //}

            //Console.WriteLine();
            //Console.WriteLine("TOTAL TAXES: $ {0}", totalTax.ToString("F2", CultureInfo.InvariantCulture));
            #endregion

            #region 141. Estrutura try-catch
            //try
            //{
            //    int n1 = int.Parse(Console.ReadLine());
            //    int n2 = int.Parse(Console.ReadLine());

            //    int result = n1 / n2;
            //    Console.WriteLine(result);
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Division by zero is not allowed");
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine("Format error! {0}", e.Message);
            //}
            ////catch (DivideByZeroException e)
            ////{ 
            ////    Console.WriteLine("Error! {0}", e.Message);
            ////}

            #endregion

            #region 142. Bloco finally
            //FileStream fs = null;
            //try
            //{
            //    //fs = new FileStream(@"C:\temp\data.txt", FileMode.Open);
            //    fs = new FileStream(@"C:\Udemy_CSharp_COMPLETO_Programacao_Orientada_a_Objetos_Projetos\data.txt", FileMode.Open);
            //    StreamReader sr = new StreamReader(fs);
            //    string line = sr.ReadLine();
            //    Console.WriteLine(line);
            //}
            //catch (FileNotFoundException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch(DirectoryNotFoundException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    if (fs != null)
            //    {
            //        fs.Close();
            //    }
            //}        
            #endregion

            #region 143. Criando exceções personalizadas - PARTE 1
            //Console.Write("Room number: ");
            //int number = int.Parse(Console.ReadLine());
            //Console.Write("Check-in date (dd/MM/yyyy): ");
            //DateTime checkIn = DateTime.Parse(Console.ReadLine());
            //Console.Write("Check-Out date (dd/MM/yyyy): ");
            //DateTime checkOut = DateTime.Parse(Console.ReadLine());

            //if (checkOut <= checkIn)
            //{
            //    Console.WriteLine("Error in reservation: check-out date must be after check-in date");
            //}
            //else
            //{
            //    Reservation reservation = new Reservation(number, checkIn, checkOut);
            //    Console.WriteLine("Reservation: {0}", reservation.ToString());

            //    Console.WriteLine();
            //    Console.WriteLine("Enter data to update the reservation: ");
            //    Console.Write("Check-in date (dd/MM/yyyy): ");
            //    checkIn = DateTime.Parse(Console.ReadLine());
            //    Console.Write("Check-Out date (dd/MM/yyyy): ");
            //    checkOut = DateTime.Parse(Console.ReadLine());

            //    DateTime now = DateTime.Now;

            //    if (checkIn <= now || checkOut <= now)
            //    {
            //        Console.WriteLine("Error in reservation: Reservation dates for update must be future dates");
            //    }
            //    else if (checkOut <= checkIn)
            //    {
            //        Console.WriteLine("Error in reservation: check-out date must be after check-in date");
            //    }
            //    else
            //    {
            //        reservation.UpdateDates(checkIn, checkOut);
            //        Console.WriteLine("Reservation: {0}", reservation.ToString());
            //    }
            //}
            #endregion

            #region 144. Criando exceções personalizadas - PARTE 2
            //Console.Write("Room number: ");
            //int number = int.Parse(Console.ReadLine());
            //Console.Write("Check-in date (dd/MM/yyyy): ");
            //DateTime checkIn = DateTime.Parse(Console.ReadLine());
            //Console.Write("Check-Out date (dd/MM/yyyy): ");
            //DateTime checkOut = DateTime.Parse(Console.ReadLine());

            //if (checkOut <= checkIn)
            //{
            //    Console.WriteLine("Error in reservation: check-out date must be after check-in date");
            //}
            //else
            //{
            //    Reservation reservation = new Reservation(number, checkIn, checkOut);
            //    Console.WriteLine("Reservation: {0}", reservation.ToString());

            //    Console.WriteLine();
            //    Console.WriteLine("Enter data to update the reservation: ");
            //    Console.Write("Check-in date (dd/MM/yyyy): ");
            //    checkIn = DateTime.Parse(Console.ReadLine());
            //    Console.Write("Check-Out date (dd/MM/yyyy): ");
            //    checkOut = DateTime.Parse(Console.ReadLine());

            //    string error = reservation.UpdateDates144(checkIn, checkOut);

            //    if (error != null)
            //    {
            //        Console.WriteLine("Error in Reservation: {0}", error);
            //    }
            //    else
            //    {
            //        reservation.UpdateDates(checkIn, checkOut);
            //        Console.WriteLine("Reservation: {0}", reservation.ToString());
            //    }
            //}
            #endregion

            #region 145. Criando exceções personalizadas - PARTE 3
            //try
            //{
            //    Console.Write("Room number: ");
            //    int number = int.Parse(Console.ReadLine());
            //    Console.Write("Check-in date (dd/MM/yyyy): ");
            //    DateTime checkIn = DateTime.Parse(Console.ReadLine());
            //    Console.Write("Check-Out date (dd/MM/yyyy): ");
            //    DateTime checkOut = DateTime.Parse(Console.ReadLine());

            //    Reservation reservation = new Reservation(number, checkIn, checkOut);
            //    Console.WriteLine("Reservation: {0}", reservation.ToString());

            //    Console.WriteLine();
            //    Console.WriteLine("Enter data to update the reservation: ");
            //    Console.Write("Check-in date (dd/MM/yyyy): ");
            //    checkIn = DateTime.Parse(Console.ReadLine());
            //    Console.Write("Check-Out date (dd/MM/yyyy): ");
            //    checkOut = DateTime.Parse(Console.ReadLine());

            //    reservation.UpdateDates145(checkIn, checkOut);

            //    reservation.UpdateDates(checkIn, checkOut);
            //    Console.WriteLine("Reservation: {0}", reservation.ToString());
            //}
            //catch (DomainException e)
            //{
            //    Console.WriteLine("Error in reservation: {0}", e.Message);
            //}
            //catch(FormatException e)
            //{
            //    Console.WriteLine("Format error: {0}", e.Message);
            //}catch(Exception e)
            //{
            //    Console.WriteLine("Unexpected error: {0}", e.Message);
            //}
            #endregion

            #region 146. Exercício proposto (exceções)
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine());

                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());

                AccountClass146 accountClass146 = new AccountClass146(number, holder, initialBalance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                accountClass146.Withdraw(double.Parse(Console.ReadLine()));

                Console.WriteLine("New balance: {0}",accountClass146.Balance.ToString("F2", CultureInfo.InvariantCulture));

            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: {0}", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: {0}", e.Message);
            }
            #endregion

        }
        #region Função para calcular a média de um array do tipo double
        static void CalcularMediaDoubleArray(int n)
        {
            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(vect[i]);
            }

            foreach (var item in vect)
            {
                Console.WriteLine(item);
            }

            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

            double avg = sum / n;

            Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
        #endregion

        #region Função para verificar qual o maior numero entre 3 digitados
        static int Maior(int n1, int n2, int n3)
        {
            int maior = 0;
            if (n1 > n2 && n1 > n3)
            {
                maior = n1;
            }
            else if (n2 > n3)
            {
                maior = n2;
            }
            else
            {
                maior = n3;
            }
            return maior;
        }
        #endregion

        #region Função para calcular o tamanho da circunferência pelo Raio fornecido
        static double Circunferencia(double raio)
        {
            return 2.0 * Pi * raio;
        }
        #endregion

        #region Função para calcular o Volume da Circunferência pelo Raio fornecido
        static double VolumeCircunferencia(double raio)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(raio, 3);
        }
        #endregion
    }
}
