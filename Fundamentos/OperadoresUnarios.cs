using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresUnarios
    {
        public static void Executar()
        {
            var valorNegatio = -5;
            var numero1 = 2;
            var numero2 = 3;
            var Booleano = true;
            Console.WriteLine(-valorNegatio); // quando vc colocar uso sinal negativo na frente  do operando vc enverte o valor dele
            Console.WriteLine(!Booleano); // usando  !  vai ser invertido o valor  se for verdario passa para false

            numero1++; // pós fixado
            Console.WriteLine(numero1);
           
            //--numero1; // pré fixado
            Console.WriteLine(numero1);
           
            Console.WriteLine(numero1 == --numero2);

            Console.WriteLine($"{numero1} {numero2}");

        }
    }
}
