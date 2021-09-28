using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresDeAtribuicao
    { public static void Executar()
        {
            var num1 = 3;
            num1 = 7;
            num1 += 10; // num1=+num1 +10; 3 + 10;
            num1 -= 3; // num1= num1 - 3;  3-3 = 0
            num1 *= 5; // num1= num1 * 5; 3*5 =15 
            num1 /= 2; // num1= num1 / 2; 3-2

            Console.WriteLine(num1);

            int a = 1;
            int b = a;

            a++; // a = a +1 ;
            b--; // b = b -1
            Console.WriteLine("a  = " + a +" b = " + b);
             
            dynamic c = new System.Dynamic.ExpandoObject();
            c.name = "David ";
            dynamic d = c;
            d.name = "Dhosef ";
            Console.WriteLine(c.name);

        }
    }
}
