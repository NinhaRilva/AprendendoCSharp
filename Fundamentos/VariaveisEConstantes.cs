using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public  static  void Executar()
        {
            //area da circuferencia
            double raio = 4.5;
            const double PI =3.14;

            raio = 5.5;
            // PI = 31415; // erro pois PI e uma constante não poder ser modificada 

            double area = PI * raio * raio;

            Console.WriteLine(area);
            Console.WriteLine("A area é " + area);
            // tipos internos
            bool estaChovendo = true; // bool true ou false

            Console.WriteLine("Está chovendo "+estaChovendo );
            // o byte so aceita anumero positivos  e vai de 0 a 127
            byte idade = 40;
           
            Console.WriteLine("Idade "+ idade);
            // sbyte aceito numero positivo   enegativo indo -127 ate 127
            sbyte gol = sbyte.MinValue;
            Console.WriteLine("Gol=" + gol);
              // int mas usado recebe positivos e negativos ate 4gb
            int menorValorInt = int.MinValue;
            Console.WriteLine( "meno valor int ; " + menorValorInt);
            // uint é igual ao int, mas não tem sinal ele é o modulo no numero
            uint populacaoBrasileira = 207_600_00;
            Console.WriteLine("População Brasileira " + populacaoBrasileira);

            //long tambem é um interio mas, pode receber o doublo do valor tipo 8gb
            long menorValouLong = long.MinValue;
            Console.WriteLine(" Menor valor do long " + menorValouLong);
            //ulong  é igual ao long, mas não tem sinal ele é o modulo no numero
            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("Populção Mundial "+ populacaoMundial);

            // ponto flutuante  ou numeros reais
            // no float no final do numero e´preciso colocar a letra  f no final a numero
            float preçoPc = 1299.9f;
            Console.WriteLine("preço do Pc "+preçoPc);

            double valorDeMercadoDa = 1_000_000_000_000_00;
            Console.WriteLine(valorDeMercadoDa);

        }
    }
}
