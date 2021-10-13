using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoCSharp.OO;




namespace CursoCSharp.OO
{

    public class AprendendoEmpasulamento
    {
        public string Messangem = " Tenho  instragar ";
        protected string CorDeOlhos = "Verde ";
        internal ulong NumeroCelular = 9837947566;
        protected internal string JeitoDeFalar = "Use muitos ";
        private protected string SegredoFalmily =" segredo ..:";
        private string Pessoal = "Uso photoshop ";
       
        public void MeusAcessos()
        {
            Console.WriteLine(Messangem);
            Console.WriteLine(CorDeOlhos);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFalmily);
            Console.WriteLine(Pessoal);


        }  
    }
    public class AprendPrivadoProximo: AprendendoEmpasulamento
    {
         public  new void MeusAcessos()
        {
            Console.WriteLine(Messangem);
            Console.WriteLine(CorDeOlhos);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFalmily);
          //  Console.WriteLine(Pessoal); privado so pode ser visto na propria class

        }
          
    }
        class Encapsulamento
        {
            public static void Executar()
            {
            AprendendoEmpasulamento testando = new AprendendoEmpasulamento();
            testando.MeusAcessos();
            new AprendPrivadoProximo().MeusAcessos();
            Console.WriteLine() ;
            }

        }
    }

    