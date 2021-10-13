using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    // o HashSet não é indexada  e nem aceita repetição
    class ColecoesSet
    { public static void Executar()
        { // List é homogenio e indexado  é dinamicada 
            var livro = new Produto("Game of Throne ", 49.90);
            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto>
            {
                new Produto("camisa ", 29.90),
                new Produto("8ª Temporada de Game of thrones ", 99.90),
                new Produto ("Poster" , 10),
                new Produto ("Poster" , 10)

            };
            // carrinho.AddRange(combo);
            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count);
          //  carrinho.RemoveAt(3);
           foreach(var item in carrinho)
            {
            //    Console.Write(carrinho.IndexOf(item));
                Console.WriteLine(" "+item.Nome +" "+item.Preco);

            }
           // List aceita repetição
            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);
        }
    }
}
