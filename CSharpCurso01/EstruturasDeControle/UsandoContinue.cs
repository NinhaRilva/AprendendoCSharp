using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class UsandoContinue
    {
        public static void Executar()
        {
            int intervalo = 50;
            Console.WriteLine("Numeros Pares entre 1 e " + intervalo);
            for (int i = 1; i <= intervalo; i++)
            {
                if (i % 2 == 1)
                {
                    // continue vai pra proxima reptição 
                    continue;
                }
                Console.Write(i + " ");
                // forma mais simples para  numero IMPARAe só inicia com 0 ou 2 e adcionar  +2
                // forma mais simples para  numero PAR é só inicia com 1  e adcionar  +2
                //for (int i = 2; i <= intervalo; i += 2) {
                //  Console.Write(i + " ");
            }

        }
    }
}
