﻿using System;

namespace Aula11_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculo infoPlayer = new Calculo();

            // 1º opção, sem argumentos
            System.Console.WriteLine( infoPlayer.Calcular() );

            // 2º opção, com 1 argumento int
            System.Console.WriteLine( infoPlayer.Calcular(480) );

            // 3º opção, com 2 argumentos int
            System.Console.WriteLine( infoPlayer.Calcular(1000,100) );

            // 4º opção, com 2 argumentos string
            System.Console.WriteLine( infoPlayer.Calcular("Zhestkiy Palets", "Lendário") );
        }
    }
}
