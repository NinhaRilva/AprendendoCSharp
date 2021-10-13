using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {//forma Implicta, pois int e menor que double que dizer int esta contido de double
            int interio = 10;
            double quebrado = interio;
            Console.WriteLine(quebrado);
            // Explicita, pois vc precisa for pois double e maior que int 
            double nota = 9.7;
            int notaTrucunda = (int)nota; 
            // essa conversão explicita  é chamada Cast:  desta forma vc podera perde infomações pois o numero não terá mais casa decimais 
            Console.WriteLine(notaTrucunda);


            // convertendo string em int
            Console.WriteLine("Digite Sua idade");
            string stringIdade = Console.ReadLine();

            int idadeInteiro = int.Parse(stringIdade);
            Console.WriteLine("convertendo string em int:  " +idadeInteiro);
            //Ooutra forma de converte é usando esse metodo do proprio Systen convert.ToInt32()
            idadeInteiro = Convert.ToInt32(stringIdade);
            Console.WriteLine("usado o Convert " +idadeInteiro);
            // forma mais segura  para converte string em int
            /* Console.WriteLine("Digite um número");
             string palavra = Console.ReadLine();
             int numero; // pode ser asism 
             int.TryParse(palavra, out  numero);// ou da forma a baixo
             int.TryParse(palavra, out int numero); // out  quer dizer pegue a palavra e jogue dentro no numreo que eu creie
             Console.WriteLine(" TryParse E  out " + numero); // se vc digite  um string ex ev  vez do numero  7 vc digita
                                                              // sete ele retora com 0(Zero) e não vai trazer erro com nos outro casos
                */
            // existe ess duas forma
            Console.WriteLine("Digite o Primeiro número: ");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);
            Console.WriteLine(" TryParse E  out numero 1 " + numero);

            Console.WriteLine("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine(" TryParse E  out numero 2: " + numero2);


        }
    }
}
