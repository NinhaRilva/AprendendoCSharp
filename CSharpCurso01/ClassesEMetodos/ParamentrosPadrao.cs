using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class ParamentrosPadrao
    {
        public static int Somar(int a = 1, int b = 1) => a + b;

        public static void Executar()
        {
            Console.WriteLine("Soma : "+ Somar(10,23));
            Console.WriteLine("Soma : " + Somar(10));
            Console.WriteLine("Soma : " + Somar());
            Console.WriteLine("Soma : " + Somar(b: 7));
        }
    }
}
