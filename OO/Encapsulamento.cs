using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulamento;


namespace CursoCSharp.OO
{
    public class FilhoNaoReconhecido : SubCelebridade
    {
        public void MeusAcessos()
        {
            Console.WriteLine("FilhoNaoReconhecido..:");
            Console.WriteLine(InfoPublic);
            Console.WriteLine(CorDosOlhos);
            //Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            // Console.WriteLine(SegredoFamilia);
            // Console.WriteLine(UsaMuitoPhotoshop);
            {

            }
        }
        public class AmigoDistante
        {
            public readonly SubCelebridade amiga = new SubCelebridade();
            public void MeusAcessos()
            {
                Console.WriteLine("AmigoDistante..:");

                Console.WriteLine(amiga.InfoPublic);
                // Console.WriteLine(amiga.NumeroCelular);
                // Console.WriteLine(amiga.JeitoDeFalar); 
                // Console.WriteLine(amiga.NumeroCelular); 
                // Console.WriteLine(amiga.SegredoFamilia); 
                // Console.WriteLine(amiga.UsaMuitoPhotoshop); 

            }
            class OOEncapsulamento
            {
                public static void Executar()
                {
                    SubCelebridade sub = new SubCelebridade();
                    sub.MeuAcessos();
                    new FilhoReconhecido().MeuAcessos();
                    new AmigoProximo().MeusAcessos();
                }
            }
        }
    }
}
