using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class UsandoBreak
    {
        public static void Executar()
        {
            //Random cria numeros aleatorios
            Random random = new Random();
            int numero = random.Next(1, 51);
            Console.WriteLine("O numero que queremos é  "+numero);
             for (int i = 1; i <= 50; i++)
            {
                Console.Write(" é o numero queremos? "+i+" ") ;
                if(i == numero)
                {
                    // O uso do break neste para quando o numero for encontra ele sair do laço
                    Console.WriteLine("  Sim! ");
                    break; 
                    
                }
                else
                {
                    Console.WriteLine("  Não!  ");
                }

            }
            Console.WriteLine("----------   Fim  ---------");

        }
    }
}
