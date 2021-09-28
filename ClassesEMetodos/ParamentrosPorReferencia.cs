using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{

    class ParamentrosPorReferencia
        //Metodo
    {  public static void AlterarRef( ref int numero)
        {

            numero = numero +1000;
        }
        // Metodo
        public static void AlterarOut( out int numero1, out int numero2)
        { // no caso out tem que ser inicializar 
            numero1 = 0; 
            numero2 = 0;

            numero1 = numero1 +  15;
            numero2 = numero2 +30;
        }
        public static void Executar()
        {
            int a = 3;
            AlterarRef(ref a);
            Console.WriteLine(a);

            // out tem um aunica direção
         //   int b;
            AlterarOut(out int b, out int c);
            Console.WriteLine(b +" e "+ c);


         


        }
    }
}
