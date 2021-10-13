using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresLogicos
    { 
        public  static void Executar()
        {
            // Operadore logicos:
            /* && = E todos tem que ser true
               || = ou  apanas 1 precisa ser true
               != negação  se for  true transforma em false e se for falso tras forma em true
                ^ operador de ou exclusivo: se apenas um dos valores de entrada for VERDADEIRO
             */

            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            bool couprouTv50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("Comprou a tv 50 ? " +couprouTv50);

            bool comprouSorvet = executouTrabalho1 || executouTrabalho2;

            Console.WriteLine("comprou sorvete "+ comprouSorvet );
             // operador de ou exclusio é  o  ^
            bool comprouTv32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine("Comprou a tv de  32 ? " +comprouTv32);

            Console.WriteLine("mas Saudavel? " + !comprouSorvet);
        }
        
    }
}
