using System;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa dadospessoa= new Pessoa();
            Console.WriteLine("Digite seu nome");
            string nomePessoa = Console.ReadLine();
            Console.WriteLine("Digite  sua idade");
            int idadePessoa = int.Parse(Console.ReadLine());


            dadospessoa.Nome = nomePessoa;
            dadospessoa.Idade = idadePessoa;
            
           dadospessoa.ApresentarNoConsole();
           
            var pessoasInfor = new Pessoa();
            pessoasInfor.Nome = "David";
            pessoasInfor.Idade = 13;
            Console.WriteLine();

        }

    }
}
