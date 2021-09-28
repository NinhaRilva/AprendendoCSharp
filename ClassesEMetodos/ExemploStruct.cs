using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{ 
    interface Ponto {
        // Método de interface é sempre public 
        void MoverNaDiagonal(int delta);
    }
    struct Coordenada: Ponto {
        public int X;
        public int Y;
        public Coordenada(int x, int y)
    {
            X = x;
            Y = y;

    }
        public void MoverNaDiagonal(int delta)
        {
            X += delta;
            Y += delta;
        }
}
    class ExemploStruct
    {
        public static void Executar()
        {
            Coordenada coordenadaInicial;
            coordenadaInicial.X =2;
            coordenadaInicial.Y=2;
            Console.WriteLine("Coodernada Inicial");
            Console.WriteLine("X =" + coordenadaInicial.X);
            Console.WriteLine("Y =" + coordenadaInicial.Y);
            Console.WriteLine();

        }
    }
}
