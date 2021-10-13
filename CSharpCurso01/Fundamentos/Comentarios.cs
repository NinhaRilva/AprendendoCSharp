using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{ 
    class Comentarios
    {/// <summary>
    /// 
    /// </summary>
   
        public static void Executar()
        {           
            // cuidado com comentarios desnecessarios
            Console.WriteLine("Código claro é sempre melhor");

            //basta colocara 3barra que ele via gera o xml comments que o  ///summary
            //summary usado para explicar o que o programa faz ou fazer uma doucomentação do codigo
            Console.WriteLine("O C# tem  o XML Comments");
        }

    }
}
