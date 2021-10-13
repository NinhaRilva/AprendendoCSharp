using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaFor
    {
        public static void Executar()
        {

            //int i = 1;
            //while (i <= 10)
            //{
            //    i++;
            //    Console.WriteLine("O valor de  i é : " + i);
            //}

            // modo mais simple feito com FOR
            //for(int i =1; i <= 10; i++)
            //{
            //    Console.WriteLine("O valor de   i é: "+i);
            //}
            //Exemlo de fixação

            double somatorio = 0;
            string entrada;
            Console.Write("informe o tamanho da turma: ");
            entrada = Console.ReadLine();
           // usando o TryParse  abaiza que caso for colococando umm nuremso errda
            int.TryParse(entrada, out int tamanhoDaTurma);


            for (int i =1; i<=tamanhoDaTurma; i++)
            {
                Console.WriteLine("Informe a nota do aluno: " + i);
                entrada = Console.ReadLine();
                Double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual;
            }
            double media = tamanhoDaTurma > 0 ? somatorio / tamanhoDaTurma : 0;
            Console.WriteLine("Media d aturma: " + media);
        }
    }
}
