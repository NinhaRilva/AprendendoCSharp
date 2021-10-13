using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIfElseIf
    {
        public static void Executar()
        {
            Console.WriteLine("Digite a no do aluno");
           double nota= double.Parse(Console.ReadLine());
           //string entrada = Console.ReadLine();
           //  Double.TryParse(entrada, out double nota);

            if (nota >= 9.0)
            {
                Console.WriteLine(" Quandro de honra");
            }
            else if(nota >=7.0){
                Console.WriteLine("aprovado");
            }
            else if(nota >=5 ){
                Console.WriteLine("Recuperção");
            }
            else 
            {
                Console.WriteLine("Reprovado");
            }

            Console.WriteLine("------------Fim !!------------");
        }
    }
}
