using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Cliente
    {
        public string Nome;
        // readonly somente leitura  não pode ser atribuída com valores fora de seu construtor de classe
        readonly DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
           Nascimento = new DateTime(2007, 10 , 04);
        }
        public  string GetDataDeNascimento()
        {
            return string.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);

        }
    }
    class Readonly
    {
        public static void Executar()
        {
            Cliente novoClient = new Cliente("Eliane",new DateTime(1959,11,3));
            Console.WriteLine(novoClient.Nome +" Nasceu "+ novoClient.GetDataDeNascimento());

          

        }
    }
}
