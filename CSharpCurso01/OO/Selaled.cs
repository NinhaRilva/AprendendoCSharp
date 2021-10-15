using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCurso01.OO
{
    sealed class SemFilho
    {
        public double ValorDaFortuna()
        {
            return 1_807_345.65;

        }
    }
    //   class SouFilho : SemFilho{    }
    class avo
    {
        public virtual bool HonraFamilia()
        {
            return true;
        }
    }
    class Pai:avo {
        public override sealed bool HonraFamilia()
        {
            return true;
        }
    }
  
    class FilhoRebelde : Pai
    {
    }
    class Selaled
        
    {
        public static void Executar()
        {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());
            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine( filho.HonraFamilia());
        }
    }
}
