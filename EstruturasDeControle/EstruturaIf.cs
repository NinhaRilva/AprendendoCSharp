using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIf
      
    {
        public static void Executar()
        {
            bool bomComportamento = false;
           
            Console.WriteLine("Digite a nota do aluno: ");
           string entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            Console.WriteLine("possui bom comportamento (S/N): ");
            entrada = Console.ReadLine();

            //if(entrada == "S" || entrada == "s")
            //    bomComportamento = true;

            // bomComportamento= entrada */== "S" || entrada == "s";
             
            // O ToLower tranforma letra maiscula para minuscula
            bomComportamento = entrada.ToLower() == "s";  

            if (nota >= 9.0 && bomComportamento)
            {
                Console.Write("Quadro de Horra");
             }

        }
        
    }
}
