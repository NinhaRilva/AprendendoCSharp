using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{

    // public struct Dependente
    public class Dependente
    {
        public string Nome;
        public int Idade;
    }



    public struct Dependentes   // se vc altera de struct para class vc veara diferência
   // public class Dependente
    { // string é por referência
        public string Nome;
        // int é  po  Valor
        public int Idade;
           
    }

    class ValorVsReferencia
    { public static void Executar()
        {
            int numero = 3;

            int copiaNumero = numero;
            Console.WriteLine(numero + " " + copiaNumero + " ");
            numero++;
            Console.WriteLine(numero + " " + copiaNumero + " ");
            numero++;

            Dependente dep = new Dependente();

            int copiandoNumero = numero;
            Console.WriteLine(numero + " , "+copiandoNumero);
            numero++;
            Console.WriteLine(numero + " e " + copiandoNumero);

            dep = new Dependente()

            {
                Nome = "Dhosef",
                Idade = 12
            };
            Dependente copiaDep = dep;

            Console.WriteLine(dep.Nome +" " +copiaDep.Nome);
            Console.WriteLine(dep.Idade + " " + copiaDep.Idade);
            copiaDep.Nome = "David";
         
            dep.Idade = 13;
            Console.WriteLine(dep.Nome + " " + dep.Idade +" anos");
            Console.WriteLine(copiaDep.Nome + " " + copiaDep.Idade + " anos");

            Console.WriteLine(dep.Nome+" tem "+ dep.Idade+ " anos");
            Console.WriteLine(copiaDep.Nome + " tem " + copiaDep.Idade + " anos" + "      copia");

            Console.WriteLine(" ");
            copiaDep.Nome = "David";
            copiaDep.Idade = 13;

            Console.WriteLine(dep.Nome + " tem " + dep.Idade + " anos");
            Console.WriteLine(copiaDep.Nome + " tem " + copiaDep.Idade + " anos" + "      copia");
        }

    }
}
