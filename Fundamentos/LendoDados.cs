﻿using System;
using System.Globalization;
namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {  

            Console.Write("Qual o seu Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Qual é sua Idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.Write("Qual é o seu salario: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Nome {nome} idade {idade} tem o  Salario {salario}");




        }
    }
}
