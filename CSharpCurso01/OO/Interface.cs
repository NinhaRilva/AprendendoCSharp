using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCurso01.OO
{// uma interface sempre é abstract

    interface Operacaobinbaria
    {
        public int Operacao(int a, int b);

    }
    class Soma : Operacaobinbaria
    {
        public int Operacao(int a, int b)
        {
            return a + b;

        }
    }

    class Subtracao : Operacaobinbaria
    {
        public int Operacao(int a, int b)
        {
            return a - b;
        }
    }
    class Multiplicacao : Operacaobinbaria
    {
        public int Operacao(int a, int b)
        {
            return a * b;
        }

    }
    class Calculadora
    {
        List<Operacaobinbaria> operacoes = new List<Operacaobinbaria>
        {
            new Soma(),
            new Subtracao(),
            new Multiplicacao()
        };

        public string ExecutarOperacao(int a, int b)
        {
            string resultado = " ";
            foreach (var op in operacoes)
            {
                resultado += $"usando{op.GetType().Name} = {op.Operacao(a, b)}\n";
            }
            return resultado;
        }
    }

    class Interface
    {
        public static void Executar()
        {
            var cal = new Calculadora();
            var result = cal.ExecutarOperacao(20, 5);
                Console.WriteLine(result);


        }
    }
}

