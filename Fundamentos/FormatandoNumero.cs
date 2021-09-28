using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            // usando ToString  um valor em string
            // ("F1")  desa forma estou dizendo que quero com uma casa decimal
            // para que seja com mais casa decimais é mudo para o valor que deseja ex: F2 , F3 ...
            //("C") sera colocado um  valor monetario ou seja (moeda)  de acodor com as conf. do seu pc 
          // ("P")  de Percentual
           
            
            double ExemploValor = 15.175;

            Console.WriteLine(ExemploValor.ToString("F1"));
            // Exemplo de ("C")esta caso ficara assim ( R$ 15,18)
            Console.WriteLine(ExemploValor.ToString("C"));
            // no caso a baixo ele va multiplica por 100 e vai colocar o simbolo de %
            Console.WriteLine(ExemploValor.ToString("P"));
            
            // usando # vc estara dizendo que quer 3 casa decimal
            Console.WriteLine(ExemploValor.ToString("#.###"));

            //para colocar zero na frente de numero  ateé completa o valor que foi informando no ("D "):
            int valorInteiro = 254;
            // no caso a abaixo ficara  00254 totalizando 5 valores
                       
            Console.WriteLine(valorInteiro.ToString("D5")) ;





        }
    }
}
