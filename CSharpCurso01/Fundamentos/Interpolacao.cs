using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class Interpolacao
    {
        public static void Executar(){

            string nome ="Notebook Gamer";
            string marca = "Dell";
            double preco = 5800.00;

            // esse  sinal de  +  e uma cocatenação
            Console.WriteLine("O "+ nome+ " de marca "+ marca +" Custa "+ preco+ ".");
            // outra forma é a interpolação
            Console.WriteLine("O {0} da marca {1} custa {2} .", nome, marca, preco );
            // e a 3 forma e  

            Console.WriteLine($"O {nome} de marca {marca} custa: {preco}.");

            Console.WriteLine($" A Marca {marca}  é legal");

            Console.WriteLine($"1 + 1 = { 1+1 } ");
           // Neste caso ele fez um interpolção ele executou um opreção dentr da chaves
          


    }  
    }
}
