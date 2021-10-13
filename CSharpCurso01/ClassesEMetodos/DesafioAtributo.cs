using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class DesafioAtributo
    { // esse é uma instancia da class  ele precisa ser instaciado
            int a = 10;
            public static void Executar()
            { // Desafio : Acessar  variavel 'a' dentro do método Executar
                var numeroA = new DesafioAtributo();

                Console.WriteLine(numeroA.a);
            }
        
    }
}
