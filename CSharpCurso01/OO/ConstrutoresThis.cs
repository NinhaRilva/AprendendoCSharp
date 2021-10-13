using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public class Aniamal
    {
        public string Nome { get; set; }

        public Aniamal(string nome)
        {
          Nome = nome;
        }
    }
    public class Cachorro : Aniamal
    {
        public double Altura { get; set; }
    
    public Cachorro(string nome): base(nome)
    {
            Console.WriteLine("Cachorro "+ nome + " foi inicalizado");
    }
        public Cachorro(string nome, double altura) : this(nome)
        {
            Altura = altura;
            
        }
        // esse metodo converte o objeto para texto
        public override string ToString()
        {
            return "O cachorro " + Nome + "  mede " + Altura+" cm de altura";
        }
    }



    class ConstrutoresThis
    { public static void Executar()
        {
          var pingo = new Cachorro(" Pingo", 21.3);
          var spike = new Cachorro(" Spike");


            Console.WriteLine(pingo);
            Console.WriteLine(spike);

        }

    }
}
