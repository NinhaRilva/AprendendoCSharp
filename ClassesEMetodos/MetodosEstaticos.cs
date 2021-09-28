using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
   
        class CalculadoraEstatica
        {
            // Método de Classe ou Método estático!
            public static int Multiplicar(int a, int b)
            {
                return a * b;
            }
            // Método de instância !!
            public int Somar(int a, int b)
            {
                return a + b;
            }
        }

        class MetodosEstaticos
        {
            public static void Executar()
            {
                var resultado = CalculadoraEstatica.Multiplicar(2, 2);
                Console.WriteLine("resultado com Static " + resultado);

                var calc = new CalculadoraEstatica();
                Console.WriteLine("Resultado da soma com static " + calc.Somar(2, 5));
                Console.WriteLine("Resultado da soma com static " + CalculadoraEstatica.Multiplicar(2, 3));


            }
        }
}
