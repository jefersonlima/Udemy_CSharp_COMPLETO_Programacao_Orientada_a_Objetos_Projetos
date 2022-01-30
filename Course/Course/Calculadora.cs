using System;

namespace Course
{
    class Calculadora
    {
        public static double Pi = 3.14;
        #region Função para calcular o tamanho da circunferência pelo Raio fornecido
        public static double Circunferencia(double raio)
        {
            return 2.0 * Pi * raio;
        }
        #endregion

        #region Função para calcular o Volume da Circunferência pelo Raio fornecido
        public static double VolumeCircunferencia(double raio)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(raio, 3);
        }
        #endregion
    }
}
