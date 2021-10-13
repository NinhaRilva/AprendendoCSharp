using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class Inferencia
         {
        public  static void Executar()
        {
            var nome = "Adriana";
            var idade = 40;
            var precoProduto = 15.50;

            Console.WriteLine("Nome " + nome);
            Console.WriteLine("idade " + idade);
            Console.WriteLine(" Preço do Produto " + precoProduto);

            // a variavel var assume qualquer tipo  
            // usando a o var vc é obrigado a iniciliza-la
            //  var nome; desa forma dara erro var nome = "David";
            // diferente  do stipos int e double  ex:
            int a;
            a = 10;
              int b = 2 +a;
            Console.WriteLine(b);
         

        }
    }
}
