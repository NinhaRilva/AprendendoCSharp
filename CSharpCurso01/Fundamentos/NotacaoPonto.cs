using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {  /// <summary>
    /// anotação ponto est muiot presente no  condigo 
    /// com o ponto vc tem acesso as  fucionalidade associada de acordo com o tipo
    /// </summary>
         public static void Executar()
        {

            //ToUpper() toda letra maiuscula
           // o Insert vai insire na world na 3 posição 
           // o replace ele vai trocar wold por mundo
            var saudacao = "olá ".ToUpper()
                .Insert(3, " world ")
                .Replace(" World " , " Mundo! ");
            Console.WriteLine(saudacao);
             // .Length diz o tamanho não precisa de paraentse poi ele não é um metodo
            Console.WriteLine("Teste".Length);
             // null que dizer que esta vazio            
            String valorImportante = null;
            //  o sinal de ?  faz com que  .Length só via ser acessado se o valorImportante esteja definina e não null
            //  a ? nao deixa seu codigo quebra

            Console.WriteLine(" vazio "+valorImportante?.Length);
           
            // esse abaixo vai da erro pois  .Length não aceita vazio
           //   Console.WriteLine(valorImportante.Length);

        }
    }
}
