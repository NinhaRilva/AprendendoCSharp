using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{

    public enum Genero
    {
        Acao,
        Aventura,
        Terror,
        Animancao,
        comedia
    };
    public class Filme
    {
        public string Titulo;
        public Genero GeneroDoFilme;

    }
    class ExemploEnum
    {
       
        public static void Executar()
        {
            int id = (int)Genero.Animancao;
            Console.WriteLine(id);

            var filmeFamilia = new Filme();
            filmeFamilia.Titulo = "Lucas";
            filmeFamilia.GeneroDoFilme = Genero.Aventura;
            Console.WriteLine("Filme: "+filmeFamilia.Titulo + " é " + filmeFamilia.GeneroDoFilme);

         

                
                
                }
    }
}
