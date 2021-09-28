using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;
        public Carro() { }

        public Carro(string modelo,
            string fabricante, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }
    }
    class Construtores
    {
        public static void Executar()
        {
            Carro carro1 = new Carro();
            carro1.Fabricante = "FIAT";
            carro1.Modelo = "Siena";
            carro1.Ano = 2019;

            Console.WriteLine(carro1.Fabricante
                + " modelo " + carro1.Modelo
                + " de ano " + carro1.Ano);
            Carro carro2 = new Carro("Ka ", " Ford ", 2015);


            Console.WriteLine(carro2.Fabricante + " " + carro2.Modelo + " " + carro2.Ano);

            Carro carro3 = new Carro()
            {
                Fabricante = "Chevrole",
                Modelo = "corsa",
                Ano = 2020
            };
            Console.WriteLine(carro3.Fabricante 
                + " " + carro3.Modelo + " " 
                + carro3.Ano);

        }
    } 
}

