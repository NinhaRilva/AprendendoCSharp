using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class ColecaoStack
    { public static void Executar()
        {  // o ultimo será o primeiro
            var pilha = new Stack();
            // Push para adicionar
            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14f);
            Console.WriteLine("Pilha");
            foreach(var item in pilha)
            {
                Console.Write(item +"   ");
            }
            // \nPop vai pula linha e vai remover o ultimo elemento
            Console.WriteLine("\nPop Removeu: " +pilha.Pop());
            Console.WriteLine(" ");
            Console.WriteLine("item Restante");
            foreach (var item in pilha)
            {
                Console.Write(item+ "   ");
            }
            Console.WriteLine();

            //outra possibilidade é chama o Peek  ele vai pega o ultimo da pilha ,mas não vai remover
            Console.WriteLine("\nPeek: "+ pilha.Peek());
           // esse Count ser
            Console.WriteLine(pilha.Count);
        }
    }
}
