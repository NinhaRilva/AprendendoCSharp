using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{    public class Produto
    {
        public string Nome;
        public double Preco;
        // este atributo agora pertence a classe  e não as instancia
        public static double Desconto = 0.1;

        public Produto()
        {
        }
        public Produto(string nome, double preco, double desconto)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }
        public double CalcularDesconto()
        {
            return Preco - Preco * Desconto;
        }
    }

    class AtributosEstaticos
    {
        public static void Executar()
        {
            var produto01 = new Produto("Caneta", 3.2, 0.1);
            var produto02 = new Produto()
            {
                Nome = "Borracha",
                Preco = 5.3

                // Desconto = 0.5 // pois este é um atributo da classe não pode ser instanciado

            };
            // usado direto pela class Produto
            Produto.Desconto = 0.5;

            Console.WriteLine("Preço com desconto " + produto01.CalcularDesconto());
            Console.WriteLine("Preço com desconto " + produto02.CalcularDesconto());
            // como este atributo é static o desconto vai servir para toda a classe 
            // para que esse atributo só possa valer para uma classe  é preciso tira o nome static

        }
    }
}
