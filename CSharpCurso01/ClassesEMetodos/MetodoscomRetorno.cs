using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{    class CalculadoraComum
    {
        public int Somar(int a, int b)
        {
            return a + b;

        }
        public int subtrair(int a, int b)
        {
            return a - b;

        }
        public int multiplicar( int a, int b)
        {
            return a *b;

        }
    }
    class CalculadoraCadeia
    {  //  esse atributo memoria esta com letra minuscula porque ele é interma dentro desta classe
        int memoria;
        public CalculadoraCadeia Soma(int a)
        {
            memoria += a;
           // usando o this para retorna a propria classe Calculadora
           // this instacia atual que vc está trabalho
            return this;
        }
        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
        }
         public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }
        public int Resultado()
        {
            return memoria;
        }

    }

   class MetodoscomRetorno
    {

        public static void Executar()
        {
           var calculadora = new CalculadoraComum();
            var resultado = calculadora.Somar(5, 5);
            Console.WriteLine(resultado);
            Console.WriteLine(calculadora.subtrair(2, 7));     
            Console.WriteLine(calculadora.multiplicar(3, 4));

            var calcualdoraEncadeada = new CalculadoraCadeia();
            calcualdoraEncadeada.Soma(3).Multiplicar(3).Imprimir().Limpar().Imprimir();
            resultado = calcualdoraEncadeada.Soma(3).Multiplicar(2).Resultado();
            Console.WriteLine(resultado);
                
        }
    }
}

