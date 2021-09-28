using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class ColecoesDictionary
    {// Dictionary e uma estrutura chave valor
        public static void Executar() 
        { // a a chave não aceita reptição neste caso o int que sera o (ano do filme )
            // mas já  o valor aceita repitçã neste caso  string (nome do filme)
           
            var filmes = new Dictionary<int, string>();
            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2004, "Os Incríveis");
            filmes.Add(2006, "O Grande Truque");

             // verificar se a chave esta contida
            if (filmes.ContainsKey(2004))
            {  // neste vc colocar um chave que não existe ele dar um erro
                Console.WriteLine("2004: "+ filmes[2004]);

                // neste vc colocar um chave que não existe ele retorna um string vazia
                Console.WriteLine("2004: "+filmes.GetValueOrDefault(2004));
            }
            // verificar se o valor esta contido
            Console.WriteLine(filmes.ContainsValue("Amnésia"));
           
            // metodo para remover
            Console.WriteLine("Removeu? "+ filmes.Remove(2004));
           
            // pega o valor atrraves da chave !
            filmes.TryGetValue(2006, out string filme2006);
            Console.WriteLine("Filmes: "+filme2006 +" !");
            Console.WriteLine();

            // 4 formas de percorre o dicionaro 
            //1º percorrendo so a chave!
               foreach(var chave in filmes.Keys)
            {
                Console.WriteLine(chave);
            }
            Console.WriteLine();
           // 2º percorrendo só  o valor!
           foreach(var valor in filmes.Values)
            {
                Console.WriteLine(valor);
            }
            Console.WriteLine();
           // 3º percorrer chave e valor! foma , mais dificil
            foreach(KeyValuePair<int, string> filme in filmes)
            {
                Console.WriteLine(filme.Value+" é de "+ filme.Key+".");
            }
            Console.WriteLine();
            // 4º outra forma de  percorrer chave e valor! fomra mais simple
            foreach(var filme in filmes)
            {
                Console.WriteLine(filme.Value + " é de " + filme.Key + ".");
            }
        }
    }
}
