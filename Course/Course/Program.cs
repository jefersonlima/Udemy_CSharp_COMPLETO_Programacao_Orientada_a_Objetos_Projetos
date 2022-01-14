using System;
using System.Globalization;

namespace Course
{
    class Program
    {
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
            int n1 = 3 + 4 * 2;
            Console.WriteLine(n1);

            int n2 = (3 + 4) * 2;
            Console.WriteLine(n2);

            int n3 = 17 % 3; //resto da divisão
            Console.WriteLine(n3);

            int n4 = 10 / 8;
            Console.WriteLine(n4);
            double n4_1 = (double)10 / 8;
            Console.WriteLine(n4_1);
            double n4_2 = 10.0 / 8;
            Console.WriteLine(n4_2);

            double a = 1.0, b = -3.0, c = -4.0;
            //double delta = b * b - 4.0 * a * c;
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);


            #endregion
        }
    }
}
