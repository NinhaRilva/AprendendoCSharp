using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCurso01.OO
{  // class abstract não pode ser instancianda 
   
    public abstract class Celular
   //public class Celular
    {
        public abstract string Assistente();
        public string tocar()
        {
            return "Trim ,Trim , Trim...;";
        }

        public class Samsung : Celular {
            // quando vc sobrescreve  um metodoé preciso colo override
            public override string Assistente()
            {
                return "Óla! Meu nome é Bixby!";
            }
        }
        public class IPhone: Celular
        {
            public override string Assistente()
            {
                return "Óla! Meu nome é Spiri!";
            }

        }

    }


    class Abstract
     {
        public static void Executar()
        {
            //Celular celular = new Celular();
            var celulares = new List<Celular>
            {
                new Celular.IPhone(),
                new Celular.Samsung()
            };
            foreach(var celular in celulares)
            {
                Console.WriteLine(celular.Assistente());
            }

        }
    }
}
