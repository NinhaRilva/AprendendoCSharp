using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosNome
    {
        public static void Formatar(int dia, int mes, int ano)
            {
                Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano);
                //Console.WriteLine(dia.ToString("D2")+"/"+mes.ToString("D2")+"/"+ano);

            }
            public static void Executar()
            {   // não precisa intancia pois a classe é static
                //  se não fosse statac ficaria assim var formatarData =new  ParametrosNomeados();
                Formatar(mes: 1, dia: 6, ano: 2007);
            }
    }
}
