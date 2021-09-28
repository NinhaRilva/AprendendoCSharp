using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresRealcionais
    {
        public static void Executar()
        { // relaçoes entre valores  
          //  menor < //  maior >  // igual ==  //  diferente !=  
          //  menor ou  igual <=  // maior ou igual <=

            // double nota = 6.0;
            Console.Write("Digite a nota: ");
            double nota = double.Parse(Console.ReadLine()); 
            double notaDeCorte = 7.0;
            Console.WriteLine("Nota Invalida? {0} ", nota > 10.0);
            Console.WriteLine("Nota Invalida? {0} ", nota < 00.0);
            Console.WriteLine("Perfeito {0} ", nota == 10.0);
            Console.WriteLine("Tem com melhora? {0}", nota != 10.0);
            Console.WriteLine("Passou por media {0}", nota >= notaDeCorte);
            Console.WriteLine("Recuperção  {0}", nota < notaDeCorte);
            Console.WriteLine("reprovado  {0}", nota <= 3.0);



        }
    }
}
