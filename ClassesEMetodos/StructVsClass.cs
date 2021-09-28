using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
<<<<<<< HEAD
{
    //classe (um tipo de referência) e struct (um tipo de valor).
=======
{ // struct é por valor
>>>>>>> be47f22ed7a044543bb92cdffb0b6af45e1b0f97
    public struct Sponto
    {
        public int X;
        public int Y;
<<<<<<< HEAD

        public static implicit operator Sponto(Cponto v)
        {
            throw new NotImplementedException();
        }
    }

=======
    }
    // slass é por referência
>>>>>>> be47f22ed7a044543bb92cdffb0b6af45e1b0f97
    public class Cponto
    {
        public int X;
        public int Y;
    }
    class StructVsClass
    {
        public static void Executar()
        {
<<<<<<< HEAD
            Sponto ponto1 = new Sponto { X = 1, Y =3 };
            Sponto copiaPonto1 = ponto1;
            ponto1.X = 3;  // atribuição po valor
            Console.WriteLine("Ponto1 = "+ ponto1.X);
            Console.WriteLine("Copia  do ponto1 = "+ copiaPonto1.X);
            Console.WriteLine( "   ");

            Cponto ponto2 = new Cponto { X = 1, Y = 3 };
            Cponto copiaPonto2 = ponto2;
            ponto2.X = 4;  // atribuição por referecia

            Console.WriteLine("Ponto2 = " + ponto2.X);
            Console.WriteLine("Copia do ponto2 = " + copiaPonto2.X);


        }
=======
            Sponto ponto1 = new Sponto { X = 1, Y = 3 };
            Sponto copiaPonto1 = ponto1;
           ponto1.X = 3;

            Console.WriteLine("Ponto1: " + ponto1.X);
            Console.WriteLine( "Copia Ponto1:  " + copiaPonto1.X);
            
            Cponto ponto2 = new Cponto { X = 2, Y = 4 };
            Cponto copiaPonto2 = ponto2;
            ponto2.X = 4;

            Console.WriteLine("Ponto2: " + ponto2.X);
            Console.WriteLine("Copia Ponto2: " + copiaPonto2.X);
          
    }
>>>>>>> be47f22ed7a044543bb92cdffb0b6af45e1b0f97
    }
}
