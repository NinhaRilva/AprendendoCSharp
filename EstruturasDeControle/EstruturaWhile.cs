using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaWhile
    { 
        public static void Executar()
        {
            int palpite = 0;

            //A classe Random fornece métodos definidos que geram inteiros aleatórios.
            Random random = new Random();

            // passando os intervalo 1 ,16 ele vai gerar  de( 1 a 15)
            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativaRestante = 5;
            int tentativas = 0;

            while(tentativaRestante > 0 && !numeroEncontrado)
            {
                Console.WriteLine("Digite seu palpite");
                palpite = int.Parse(Console.ReadLine());
                tentativas++;
                tentativaRestante--;
                if( numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    //cria uma variavel para manter a cor original 
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Parabéns você acertou  "+ tentativas);
                    Console.BackgroundColor = corAnterior;
                }
                else if(palpite > numeroSecreto)
                {
                    Console.WriteLine("Numero secreto é Menor ... Tente novamente");
                    Console.WriteLine("Tentativas restante " + tentativaRestante);
                }
                else 
                {
                    Console.WriteLine("Numero secreto é Maior ... Tente novamente");
                    Console.WriteLine("Tentativas restante " + tentativaRestante);
                }

                    
            }
            




        }
    }
}
