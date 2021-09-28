using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{ // na fila o 1º a entra é o 1º a sair
    class ColecoesFilaQueue
    { public static void Executar()
        {
            var fila = new Queue<string>();
            //Enqueue adciona na fila ou seja ele vai enfilera
            fila.Enqueue("Adriana");
            fila.Enqueue("Angela");
            fila.Enqueue("Jhenifer");
            //Peek vai pegar o primeiro da fila ,mas não  vai remove-lo da fila
            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);
            //para tira da lista usamos Dequeue
            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);

            foreach (var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);
            Console.WriteLine(salada.Contains("item"));
            Console.WriteLine(salada.Contains("Item"));
        }

    }
}
