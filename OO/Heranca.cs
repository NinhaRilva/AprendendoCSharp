using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoCSharp.OO;

namespace CursoCSharp.OO
{
    public class Carro
    {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        public Carro(int velocidadeMaxima)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlterarVelocidade(int delta)
        {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0)
            {
                VelocidadeAtual = 0;
            }
            else if (novaVelocidade > VelocidadeMaxima)
            {
                VelocidadeAtual = VelocidadeMaxima;
            }
            else
            {
                VelocidadeAtual = novaVelocidade;
            }

            return VelocidadeAtual;
        }
         // virtual permite que o método seja subscrito
        public virtual int Acelerar()
        {
            return AlterarVelocidade(5);
        }

        public int Frear()
        {
            return AlterarVelocidade(-5);
        }
    }

    public class Uno : Carro
    {
        public Uno() : base(200)
        {

        }
    }

    public class Ferrari : Carro
    {
        public Ferrari() : base(350){
        }  // método subscrito
            public override int Acelerar()
            {
                return AlterarVelocidade(15);
            }
        // metodo escondido
        public new int Frear()
        {
            return AlterarVelocidade(-15);
        }

    }

    }
    class Heranca
    {
        public static void Executar()
        {
            Console.WriteLine("Uno... ");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar()); 
            Console.WriteLine(carro1.Acelerar());

            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());
            
        Console.WriteLine( " ----------------------------" );
           
        Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());

            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
        Console.WriteLine();
        Console.WriteLine("Ferrari com tipo Carro ...");
        // polimorfismo
        Carro carro3 = new Ferrari();
        Console.WriteLine(carro3.Acelerar());
        Console.WriteLine(carro3.Acelerar());
        Console.WriteLine(carro3.Frear());
        Console.WriteLine(carro3.Frear());
        Console.WriteLine(carro3.Frear());
        Console.WriteLine();
        Console.WriteLine("Uno com tipo Carro ...");
        // polimorfismo
       carro3  = new Uno();
        Console.WriteLine(carro3.Acelerar());
        Console.WriteLine(carro3.Acelerar());
        Console.WriteLine(carro3.Frear());
        Console.WriteLine(carro3.Frear());
        Console.WriteLine(carro3.Frear());




    }
    }



