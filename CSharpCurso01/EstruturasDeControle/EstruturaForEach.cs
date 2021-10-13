using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaForEach
    {
        public static void Executar()
        { // no caso a abaixo o foreach vai percorre cada letra da palavra ( até  a!)
            string palavra = "Opa!";
            foreach(var letra in palavra)
            {
                Console.WriteLine(letra);
            }
            // vc podera usar tanto var ou string 
             var alunos = new string[] { "Ana","David","Dhosef","Manoel" };
             foreach(string aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
             // o foreach percorre  do primeiro ate ultimo sem precisa
             // da condição de true ou false.
             // ele vai passar por todos os elementos
        }
    }
}
