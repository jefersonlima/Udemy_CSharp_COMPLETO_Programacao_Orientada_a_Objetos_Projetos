using System;
using System.Collections.Generic;
using System.Globalization;

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
            double preco = double.Parse(Console.ReadLine());
            double desconto;

            #region Usando IF
            if (preco < 20.00)
            {
                desconto = preco * 0.1;
            }
            else
            {
                desconto = preco * 0.05;
            }
            Console.WriteLine(desconto);
            #endregion

            #region Ternaria
            double descontoTernario = (preco < 20.0) ? preco * 0.1 : preco * 0.5;
            Console.WriteLine(desconto);
            #endregion

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
